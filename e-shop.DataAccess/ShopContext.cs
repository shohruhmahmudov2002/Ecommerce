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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString)
                .UseSnakeCaseNamingConvention();
        }
    }
}
