using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CorporX.Data.Configurations
{
    public class ContactUsConfiguration : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Fullname)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Message)
                .HasMaxLength(300)
                .IsRequired();
            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.ToTable("Contacts");
        }
    }
}
