using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CorporX.Data.Configurations
{
    public class SocialLinkConfiguration : IEntityTypeConfiguration<SocialLink>
    {
        public void Configure(EntityTypeBuilder<SocialLink> builder)
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
                .Property(m => m.Icon)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(m => m.Url)
                .HasMaxLength(300)
                .IsRequired();

            builder.ToTable("SocialLink");
        }
    }
}
