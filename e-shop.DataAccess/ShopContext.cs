using System.Reflection;
using e_shop.DataAccess.ModelConfiguration;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess;
public class ShopContext : DbContext
{
    private static string _connectionString = "Server=localhost;Port=5432;Database=e_shopDB;User Id=postgres;Password=pgadmin";
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    //public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<CardItem> CardItems { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ProductTag> ProductTags { get; set; }

    //public ShopContext()
    //{
    //    Database.EnsureCreated();
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region FluentAPI
        //modelBuilder.Entity<Product>()
        //    .HasKey(r => r.ProductID);

        //modelBuilder.Entity<Product>()
        //    .Property(p => p.SKU)
        //    .HasMaxLength(255)
        //    .IsRequired();

        //modelBuilder.Entity<Product>()
        //    .Property(p => p.ProductName)
        //    .HasMaxLength(255)
        //    .IsRequired();

        //modelBuilder.Entity<Product>()
        //    .Property(p => p.RegularPrice)
        //    .HasDefaultValue(0)
        //    .IsRequired();

        //modelBuilder.Entity<Category>()
        //    .Property(p => p.IsActive)
        //    .HasDefaultValue(true);



        //modelBuilder.Entity<ProductCategory>(builder =>
        //{
        //    builder.HasKey(r => new { r.ProductID, r.CategoryID });

        //    builder.HasOne(r => r.Categories)
        //        .WithMany(r => r.ProductCategories);

        //    builder.HasOne(r => r.Products)
        //        .WithMany(r => r.ProductCategories);
        //});

        ////Either one, not both need to use
        //modelBuilder.Entity<Card>(builder =>
        //{
        //    builder.HasMany(r => r.CardItems)
        //    .WithOne(r => r.Cards);

        //    builder.HasKey(r => r.CardID);

        //});

        //modelBuilder.Entity<CardItem>(builder =>
        //{
        //    builder.HasOne(r => r.Cards)
        //    .WithMany(r => r.CardItems)
        //    .HasForeignKey(r => r.CardID);
        //});


        //modelBuilder.Entity<Tag>(builder =>
        //{
        //    builder.HasKey(r => r.TagID);

        //    builder.Property(p => p.TagName)
        //    .HasMaxLength(255)
        //    .HasColumnType("varchar")
        //    .IsRequired();

        //    builder.Property(p => p.Icon)
        //    .HasMaxLength(255)
        //    .HasColumnType("varchar")
        //    .IsRequired();
        //});

        //modelBuilder.Entity<ProductTag>(builder =>
        //{
        //    builder.HasKey(r => new { r.ProductID, r.TagID });

        //    builder.HasOne(r => r.Tags)
        //        .WithMany(r => r.ProductTags)
        //        .HasForeignKey(r => r.TagID);

        //    builder.HasOne(r => r.Products)
        //        .WithMany(r => r.ProductTags)
        //        .HasForeignKey(r => r.ProductID);
        //});

        //modelBuilder.Entity<ProductCategory>(builder =>
        //{
        //    builder.HasKey(r => new { r.ProductID, r.CategoryID });

        //    builder.HasOne(r => r.Products)
        //        .WithMany(r => r.ProductCategories)
        //        .HasForeignKey(r => r.ProductID);

        //    builder.HasOne(r => r.Categories)
        //        .WithMany(r => r.ProductCategories)
        //        .HasForeignKey(r => r.CategoryID);
        //});
        #endregion
        //modelBuilder.ApplyConfiguration(new ProductConfiguration());
        //modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.SeedData();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(_connectionString)
                .UseLazyLoadingProxies()
                //.LogTo(Console.WriteLine, LogLevel.Information)
            .UseSnakeCaseNamingConvention()
            .AddInterceptors(new AuditInterceptor());
        }
    }

    //public override int SaveChanges()
    //{
    //    var entiries = ChangeTracker.Entries();
    //    var addedEntiries = entiries.Where(e => e.State == EntityState.Added);
    //    var updatedEntiries = entiries.Where(e => e.State == EntityState.Modified);
    //    foreach (var entiry in addedEntiries)
    //    {
    //        if(entiry.Entity is IAuditable entity)
    //        {
    //            entity.CreatedAt = DateTime.UtcNow;
    //            entity.CreatedBy = 1;
    //        }
    //    }

    //    foreach(var entiry in updatedEntiries)
    //    {
    //        if(entiry.Entity is IAuditable entity)
    //        {
    //            entity.UpdatedAt = DateTime.UtcNow;
    //            entity.UpdatedBy = 1;
    //        }
    //    }

    //    return base.SaveChanges();
    //}
}

