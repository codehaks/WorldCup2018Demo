using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WroldCupDemo.Models;

namespace WroldCupDemo.Data
{
    public class WorldcupDbContext : DbContext
    {
        public WorldcupDbContext(DbContextOptions<WorldcupDbContext> options)
            : base(options) { }

        public DbSet<Team> Teams { get; set; }
    }
}