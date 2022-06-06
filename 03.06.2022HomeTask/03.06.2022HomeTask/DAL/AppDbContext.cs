using _03._06._2022HomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03._06._2022HomeTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<News> News{ get; set; }
        public DbSet<NewsDetail> NewsDetails { get; set; }
    }
}
