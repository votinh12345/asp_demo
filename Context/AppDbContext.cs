using Microsoft.EntityFrameworkCore;
using hienv_asp.Models;
namespace hienv_asp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { set; get; }
        public DbSet<ErrorViewModel> ErrorViewModel { set; get; }
        public DbSet<CategoryToLayout> CategoryToLayout { set; get; }
        public DbSet<CategoryToStore> CategoryToStore { set; get; }
        public DbSet<CategoriesDescription> CategoriesDescription { set; get; }
        public DbSet<Address> Address { set; get; }
        public DbSet<Affiliate> Affiliate { set; get; }
        public DbSet<AffiliateTransaction> AffiliateTransaction { set; get; }
        public DbSet<Attributes> Attribute { set; get; }
        public DbSet<AttributeDescription> AttributeDescription { set; get; }
        public DbSet<AttributeGroup> AttributeGroup { set; get; }
        public DbSet<AttributeGroupDescription> AttributeGroupDescription { set; get; }
        public DbSet<Banner> Banner { set; get; }
        public DbSet<BannerImage> BannerImage { set; get; }
        public DbSet<BannerImageDescription> BannerImageDescription { set; get; }
        public DbSet<Blogs> Blogs { set; get; }
        public DbSet<Layout> Layout { set; get; }
        public DbSet<Country> Country { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriesDescription>()
                  .HasKey(m => new { m.category_id, m.language_id });

            modelBuilder.Entity<CategoryToLayout>()
                 .HasKey(m => new { m.category_id, m.store_id });

            modelBuilder.Entity<CategoryToStore>()
                 .HasKey(m => new { m.category_id, m.store_id });

            modelBuilder.Entity<AttributeDescription>()
                 .HasKey(m => new { m.attribute_id, m.language_id });

            modelBuilder.Entity<AttributeGroupDescription>()
                 .HasKey(m => new { m.attribute_group_id, m.language_id });

            modelBuilder.Entity<BannerImageDescription>()
                 .HasKey(m => new { m.banner_image_id, m.language_id });
        }
    }
}
