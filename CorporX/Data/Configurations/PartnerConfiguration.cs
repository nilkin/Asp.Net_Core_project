using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorporX.Data.Configurations
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Url)
                .HasMaxLength(300);
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder.ToTable("Partners");
        }
    }
}
