using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupDemo.Models;

namespace WorldCupDemo.Data
{
    public class WorldcupDbContext : DbContext
    {
        public WorldcupDbContext(DbContextOptions<WorldcupDbContext> options)
            : base(options) { }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Team>()
                .HasData(
                    new Team { Id = 1, Name = "Iran", GroupName = "B", Rank = 32, Appearances = 4, Titles = 0 },
                    new Team { Id = 2, Name = "Morocco", GroupName = "B", Rank = 40, Appearances = 4, Titles = 0 }
                );

            builder.Entity<Team>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<Team>().Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Team>().Property(t => t.Rank).HasColumnType("tinyint");
        }
    }
}