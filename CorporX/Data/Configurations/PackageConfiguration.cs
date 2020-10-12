using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace CorporX.Data.Configurations
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
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
                .HasColumnType("ntext")
                .HasMaxLength(250)
                .IsRequired();
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.BtnClass)
                .HasMaxLength(50);
            builder
                .Property(m => m.Class)
                .HasMaxLength(50);

            builder.Property(m => m.Price)
                .HasColumnType("money")
                .IsRequired();

            builder.ToTable("Packages");
        }
    }
}
