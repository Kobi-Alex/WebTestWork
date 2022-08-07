using System;
using Entrant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entrant.Infrastructure.Persistance.EntityConfigurations
{
    internal sealed class EntrantIncedentEntityTypeConfiguration
        : IEntityTypeConfiguration<EntrantIncedent>
    {
        public void Configure(EntityTypeBuilder<EntrantIncedent> builder)
        {
            builder.ToTable("Incedents");

            builder.HasKey(incedent => incedent.Name);

            builder.Property(incedent => incedent.Description)
                .IsRequired(true)
                .HasMaxLength(500);

            builder.HasOne(i => i.EntrantAccount)
                .WithMany(a => a.EntrantIncedents)
                .HasForeignKey(i => i.EntrantAccountId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
