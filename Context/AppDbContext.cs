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
        public DbSet<Language> Language { set; get; }
        public DbSet<Currency> Currency { set; get; }
        public DbSet<Store> Store { set; get; }
        public DbSet<StockStatus> StockStatus { set; get; }
        public DbSet<OrderStatus> OrderStatus { set; get; }
        public DbSet<ReturnStatus> ReturnStatus { set; get; }
        public DbSet<ReturnAction> ReturnAction { set; get; }
        public DbSet<ReturnReason> ReturnReason { set; get; }
        public DbSet<ZoneToGeoZone> ZoneToGeoZone { set; get; }
        public DbSet<LengthClass> LengthClass { set; get; }
        public DbSet<LengthClassDescription> LengthClassDescription { set; get; }
        public DbSet<WeightClass> WeightClass { set; get; }
        public DbSet<WeightClassDescription> WeightClassDescription { set; get; }
        public DbSet<User> User { set; get; }
        public DbSet<UserGroup> UserGroup { set; get; }


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

            modelBuilder.Entity<StockStatus>()
                 .HasKey(m => new { m.stock_status_id, m.language_id });

            modelBuilder.Entity<OrderStatus>()
                 .HasKey(m => new { m.order_status_id, m.language_id });

            modelBuilder.Entity<ReturnStatus>()
                 .HasKey(m => new { m.return_status_id, m.language_id });

            modelBuilder.Entity<ReturnAction>()
                 .HasKey(m => new { m.return_action_id, m.language_id });

            modelBuilder.Entity<ReturnReason>()
                 .HasKey(m => new { m.return_action_id, m.language_id });

            modelBuilder.Entity<LengthClassDescription>()
                 .HasKey(m => new { m.length_class_id, m.language_id });

            modelBuilder.Entity<WeightClassDescription>()
                 .HasKey(m => new { m.weight_class_id, m.language_id });
        }
    }
}
