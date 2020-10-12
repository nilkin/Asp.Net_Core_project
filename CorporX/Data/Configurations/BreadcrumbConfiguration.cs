using CorporX.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorporX.Data.Models
{
    public class BreadcrumbConfiguration : IEntityTypeConfiguration<Breadcrumb>
    {
        public void Configure(EntityTypeBuilder<Breadcrumb> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Path)
                .HasMaxLength(100);
            builder
                .Property(m => m.Link)
                .HasMaxLength(100);

            builder.ToTable("Breadcrumbs");
        }
    }
}
