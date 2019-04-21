using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Server.Models
{
    public class BlazorSampleContext : DbContext
    {
        public BlazorSampleContext(DbContextOptions<BlazorSampleContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Department).IsRequired();
                entity.Property(e => e.City).IsRequired();
            });
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
