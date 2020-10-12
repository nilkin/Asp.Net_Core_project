using CorporX.Data.Configurations;
using CorporX.Data.Models;
using CorporX.Data.Models.Entities;
using CorporX.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Data
{
    public class CorporxDbContext : DbContext
    {

        public CorporxDbContext(DbContextOptions<CorporxDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AboutUsConfiguration());
            builder.ApplyConfiguration(new BlogItemConfiguration());
            builder.ApplyConfiguration(new BreadcrumbConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ContactUsConfiguration());
            builder.ApplyConfiguration(new FaqConfiguration());
            builder.ApplyConfiguration(new HeroConfiguration());
            builder.ApplyConfiguration(new MemberConfiguration());
            builder.ApplyConfiguration(new MemberLinkConfiguration());
            builder.ApplyConfiguration(new PackageConfiguration());
            builder.ApplyConfiguration(new PartnerConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new ServiceConfiguration());
            builder.ApplyConfiguration(new SettingConfiguration());
            builder.ApplyConfiguration(new SocialLinkConfiguration());

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberLink> MemberLinks { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
    }
}
