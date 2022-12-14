using System;
using Entrant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entrant.Infrastructure.Persistance.EntityConfigurations
{
    internal sealed class EntrantAccountEntityTypeConfiguration
        : IEntityTypeConfiguration<EntrantAccount>
    {
        public void Configure(EntityTypeBuilder<EntrantAccount> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(account => account.Id);

            builder.Property(account => account.Name)
                .IsRequired(true)
                .HasMaxLength(60);
            builder.HasIndex(account => account.Name).IsUnique(true);

            builder.HasOne(a => a.EntrantContact)
                .WithMany(c => c.EntrantAccounts)
                .HasForeignKey(a => a.EntrantContactId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
