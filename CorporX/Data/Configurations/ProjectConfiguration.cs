using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CorporX.Data.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
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
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Category)
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Projects");
        }
    }
}
