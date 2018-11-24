using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HistoricBattles.Models;

namespace HistoricBattles.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<HistoricBattles.Models.Battle> Battles { get; set; }
        public DbSet<HistoricBattles.Models.Stage> Stages { get; set; }
        public DbSet<HistoricBattles.Models.Regiment> Regiments { get; set; }
    }
}
