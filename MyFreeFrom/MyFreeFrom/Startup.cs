using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFreeFrom.Database;
using MyFreeFrom.Entities;
using MyFreeFrom.Models;
using MyFreeFrom.Repositories;
using MyFreeFrom.Temp;

namespace MyFreeFrom
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ResturantContext>(x => x.UseSqlServer("Data Source=PC05034;Initial Catalog=Resturants;Integrated Security=True"));
            services.AddScoped<IResturantRepository, ResturantRepository>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ResturantContext resturantContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            resturantContext.Seed();

            AutoMapper.Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<Resturant, ResturantDTO>();
                });

            app.UseMvc(routes =>
        {
            routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");

            routes.MapSpaFallbackRoute(
            name: "spa-fallback",
            defaults: new { controller = "Home", action = "Index" });
        });
        }
    }
}
