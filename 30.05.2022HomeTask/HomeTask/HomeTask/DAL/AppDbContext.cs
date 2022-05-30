using HomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<MainContext> MainContexts { get; set; }

        public DbSet<Cities> Cities { get; set; }

        public DbSet<TestMonials> TestMonials { get; set; }

        public DbSet<News> News { get; set; }
        public DbSet<Project> Projects { get; set; }


    }
}
