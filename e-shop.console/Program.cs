using e_shop.DataAccess.Services;
using e_shop.DataAccess;
using e_shop.Domain.Entities;

namespace e_shop.console;
internal class Program
{
    static void Main(string[] args)
    {
        using var context = new ShopContext();

        var service = new ProductService(context);

        service.Add(new Product()
        {
            ProductName = "Apple",
            SKU = "12345",
            RegularPrice = 100.00m,
            DiscountPrice = 80.00m,
            Quantity = 10,
            ShortDescription = "Short description of the product",
            ProductDescription = "Detailed description of the product",
            ProductWeight = 1.5m,
            ProductNote = "Special note about the product",
            Published = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            CreatedBy = 1,
            UpdatedBy = 1
        });

        service.SaveChanges();


        Console.Read();
    }
}

