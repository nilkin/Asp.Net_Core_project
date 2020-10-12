using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CorporX.Data.Configurations
{
    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
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
                .Property(m => m.Heading)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("Herous");
        }
    }
}
