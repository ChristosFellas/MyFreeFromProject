using Microsoft.EntityFrameworkCore;
using MyFreeFrom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFreeFrom.Database
{
    public class MyFreeFromContext : DbContext
    {
        public MyFreeFromContext(DbContextOptions<MyFreeFromContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DietOption> DietOptions { get; set; }
    }
}
