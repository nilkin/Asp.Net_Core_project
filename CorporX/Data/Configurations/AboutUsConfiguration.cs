using CorporX.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorporX.Data.Configurations
{
    public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
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
                .Property(m => m.Context)
                .HasMaxLength(700)
                .HasColumnType("ntext")
                .IsRequired();
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder.ToTable("AboutUs");
        }
    }
}
