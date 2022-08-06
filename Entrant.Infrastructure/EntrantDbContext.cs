using System;
using Entrant.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Entrant.Infrastructure
{
    public sealed class EntrantDbContext : DbContext
    {
        public DbSet<EntrantIncedent> Incedents { get; set; }
        public DbSet<EntrantAccount> Accounts { get; set; }
        public DbSet<EntrantContact> Contacts { get; set; }

        public EntrantDbContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntrantDbContext).Assembly);
    }

}
