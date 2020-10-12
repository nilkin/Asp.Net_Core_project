using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CorporX.Data.Configurations
{
    public class FaqConfiguration : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Icon)
                .HasMaxLength(50);

            builder
                .Property(m => m.Question)
                .HasMaxLength(300)
                .IsRequired();

            builder
                .Property(m => m.Ask)
                .HasMaxLength(300)
                .IsRequired();

            builder.ToTable("Faqs");
        }
    }
}
