using CorporX.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CorporX.Data.Configurations
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Address)
                .HasMaxLength(300)
                .IsRequired();

            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Phone)
                .IsRequired()
                .HasMaxLength(15);
            builder
                .Property(m => m.Logo)
                .HasMaxLength(100);


            builder.ToTable("Settings");
        }
    }
}
