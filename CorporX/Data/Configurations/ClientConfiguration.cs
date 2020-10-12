using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
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
                .Property(m => m.Star)
                .IsRequired();
            builder
                .Property(m => m.Position)
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Clients");
        }
    }
}
