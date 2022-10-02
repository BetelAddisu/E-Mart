using Mart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color_Item>().HasKey( ci=> new
            {
                ci.ColorId,
                ci.ItemId
            });

            modelBuilder.Entity<Color_Item>().HasOne(i => i.Item).WithMany(ci => ci.Colors_Items).HasForeignKey(i => i.ItemId);
            modelBuilder.Entity<Color_Item>().HasOne(i => i.Color).WithMany(ci => ci.Colors_Items).HasForeignKey(i => i.ColorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Color> Colors{ get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Color_Item> Colors_Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Producer> Producers { get; set; }

    }
}