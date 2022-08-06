using System;
using Entrant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entrant.Infrastructure.Persistance.EntityConfigurations
{
    internal sealed class EntrantContactEntityTypeConfiguration
        : IEntityTypeConfiguration<EntrantContact>
    {
        public void Configure(EntityTypeBuilder<EntrantContact> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(contact => contact.Id);

            builder.Property(account => account.FirstName)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(account => account.LastName)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(account => account.Email)
               .IsRequired(true)
               .HasMaxLength(60);
            builder.HasIndex(account => account.Email)
                .IsUnique(true);
        }
    }
}