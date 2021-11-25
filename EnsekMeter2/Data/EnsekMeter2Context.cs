using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnsekMeter2.Models;

namespace EnsekMeter2.Data
{
    public class EnsekMeter2Context : DbContext
    {
        public EnsekMeter2Context(DbContextOptions<EnsekMeter2Context> options)
            : base(options)
        {
        }

        public DbSet<EnsekMeter2.Models.Account> Account { get; set; }
        public DbSet<EnsekMeter2.Models.MeterReading> MeterReading { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasIndex(b => b.AccountId)
                .IsUnique();
        }


    }
}
