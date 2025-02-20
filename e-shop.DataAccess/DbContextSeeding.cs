using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess;
public static class DbContextSeeding
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(builder =>
        {
            builder.HasData(
                new Product() {
                    ProductID = 4,
                    ProductName = "Banana",
                    SKU = "55555",
                    RegularPrice = 100.00m,
                    DiscountPrice = 80.00m,
                    Quantity = 10,
                    ShortDescription = "Short description of the product",
                    ProductDescription = "Detailed description of the product",
                    ProductWeight = 1.5m,
                    ProductNote = "Special note about the product",
                    Published = true,
                    CreatedBy = 2,
                    UpdatedBy = 2
                });
        });

        modelBuilder.Entity<Category>(builder =>
        {
            builder.HasData(
                new Category()
                {
                    CategoryID = 4,
                    ParentID = 2,
                    CategoryName = "Cars",
                    CategoryDescription = "All kinds of electronic items",
                    Icon = "electronics-icon.png",
                    ImagePath = "images/electronics.png",
                    IsActive = true,
                    CreatedBy = 2,
                    UpdatedBy = 2
                });
        });

        //modelBuilder.Entity<ProductCategory>(builder =>
        //{
        //    builder.HasData(
        //        new ProductCategory()
        //        {
        //            ProductID = 4,
        //            CategoryID = 4
        //        });
        //});
    }
}

