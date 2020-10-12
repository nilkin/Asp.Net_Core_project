using CorporX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorporX.Data.Configurations
{
    public class MemberLinkConfiguration : IEntityTypeConfiguration<MemberLink>
    {
        public void Configure(EntityTypeBuilder<MemberLink> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.ClassName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Url)
                .HasMaxLength(300)
                .IsRequired();

            builder
                .HasOne(m => m.Member)
                .WithMany(m => m.MemberLinks)
                .HasForeignKey(m => m.MemberId); 

            builder.ToTable("MemberLinks");
        }
    }
}
