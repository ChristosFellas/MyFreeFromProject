using Microsoft.EntityFrameworkCore;
using MyFreeFrom.Entities;
using MyFreeFrom.Shared.Enums;

namespace MyFreeFrom.Database
{
    public class ResturantContext : DbContext
    {
        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<DietOption> DietOptions { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}
