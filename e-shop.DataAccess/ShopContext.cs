using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        private static string _connectionString = "Server=localhost;Port=5432;Database=e_shopDB;User Id=postgres;Password=pgadmin";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ShopContext()
        {
            Database.EnsureCreated();
        }
        //public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString)
                .UseSnakeCaseNamingConvention();
            }
        }
    }
}
