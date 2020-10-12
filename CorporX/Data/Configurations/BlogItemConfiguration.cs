using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Data.Configurations
{
    public class BlogItemConfiguration : IEntityTypeConfiguration<BlogItem>
    {
        public void Configure(EntityTypeBuilder<BlogItem> builder)
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
                .HasMaxLength(200)
                .IsRequired(); 
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.AddedDate)
                .IsRequired();
            builder
                .Property(m => m.Text)
                .HasColumnType("ntext")
                .HasMaxLength(500);
            builder
                .Property(m => m.BlogType)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.IsSidebar)
                .HasDefaultValue(false)
                .IsRequired();

            builder.ToTable("BlogItems");
        }
    }
}
