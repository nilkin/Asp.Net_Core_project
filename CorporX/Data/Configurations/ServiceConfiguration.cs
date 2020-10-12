using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace CorporX.Data.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Content)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(m => m.Text)
                .HasColumnType("ntext")
                .HasMaxLength(500);

            builder
                .Property(m => m.Icon)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100);
            builder
                .Property(m => m.IsPromoHome)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsDeliver)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsPromoAbout)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsPromoServ)
                .HasDefaultValue(false);

            builder.ToTable("Services");
        }
    }
}
