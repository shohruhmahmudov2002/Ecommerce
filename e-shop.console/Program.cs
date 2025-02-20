using e_shop.DataAccess.Services;
using e_shop.DataAccess;
using e_shop.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace e_shop.console;
internal class Program
{
    static async Task Main(string[] args)
    {
        using var context = new ShopContext();
        var service = new ProductService(context);
        var service2 = new CategoryService(context);
        var service3 = new CustomerService(context);
        var service4 = new CardService(context);
        var service5 = new ProductTagService(context);

        #region INSERT
        //service.Add(new Product()
        //{
        //    ProductName = "Apple",
        //    SKU = "12345",
        //    RegularPrice = 100.00m,
        //    DiscountPrice = 80.00m,
        //    Quantity = 10,
        //    ShortDescription = "Short description of the product",
        //    ProductDescription = "Detailed description of the product",
        //    ProductWeight = 1.5m,
        //    ProductNote = "Special note about the product",
        //    Published = true,
        //    CreatedAt = DateTime.UtcNow,
        //    UpdatedAt = DateTime.UtcNow,
        //    CreatedBy = 1,
        //    UpdatedBy = 1
        //});

        //service.SaveChanges();

        //service2.Add(new Category()
        //{
        //ParentID = 1,
        //    CategoryName = "Electronics",
        //    CategoryDescription = "All kinds of electronic items",
        //    Icon = "electronics-icon.png",
        //    ImagePath = "images/electronics.png",
        //    IsActive = true,
        //    CreatedAt = DateTime.UtcNow,
        //    UpdatedAt = DateTime.UtcNow,
        //    CreatedBy = 1,
        //    UpdatedBy = 1
        //});

        //service2.SaveChanges();

        //var customer = new Customer()
        //{
        //    FirstName = "Shohruh",
        //    LastName = "Mahmudov",
        //    PhoneNumber = "999999999",
        //    Email = "sdfasdfafasf",
        //    Password = "Password"
        //};

        //var customerAddress = new CustomerAddress()
        //{ 
        //    CustomerID = 1,
        //    AddressLine1 = "Mirobod 12, Tashkent",
        //    AddressLine2 = "Mirobod 13",
        //    City = "Tashkent",
        //    Country = "Uzbekistan",
        //    PostalCode = "100000",
        //    PhoneNumber = "99999999",
        //};

        //var customer = new Customer()
        //{
        //    FirstName = "Shohruh2",
        //    LastName = "Mahmudov2",
        //    PhoneNumber = "9999999992",
        //    Email = "sdfasdfafasf2",
        //    Password = "Password2",
        //    CustomerAddresses = new List<CustomerAddress>()
        //    {
        //        new CustomerAddress()
        //        {
        //            CustomerID = 1,
        //            AddressLine1 = "Mirobod 12, Tashkent2",
        //            AddressLine2 = "Mirobod 132",
        //            City = "Tashkent2",
        //            Country = "Uzbekistan2",
        //            PostalCode = "1000002",
        //            PhoneNumber = "999999992",
        //        }
        //    }
        //};
        //await service3.AddCustomer(customer);
        //await service3.AddCustomerAddress(customerAddress);

        //service3.SaveChanges();

        //var card = new Card()
        //{
        //    CustomerID = 1
        //};
        //await service4.AddCard(card);

        //var cardItem = new CardItem()
        //{
        //    CardID = 1,
        //    ProductID = 1,
        //    Quantity = 1,
        //};
        //await service4.AddCardItem(cardItem);

        //var card = new Card()
        //{
        //    CustomerID = 2,
        //    CardItems = new List<CardItem>()
        //    {
        //        new CardItem()
        //        {
        //            CardID = 2,
        //            ProductID = 1,
        //            Quantity = 2
        //        }

        //    }
        //};
        //await service4.AddCard(card);

        //var cardSpecial = context.Cards.FirstOrDefault(x => x.CardID == 1);
        //cardSpecial.CustomerID = 2;
        //service4.SaveChanges();

        //var cards = service4.GetCards();
        //foreach (var card in cards)
        //{
        //    Console.WriteLine($"{card.CardID} - {card.CustomerID}");
        //}


        //var tag = new Tag()
        //{
        //    TagID = 1,
        //    TagName = "New Tag",
        //    Icon = "tag-icon.png",
        //    CreatedAt = DateTime.UtcNow,
        //    UpdatedAt = DateTime.UtcNow,
        //    CreatedBy = 1,
        //    UpdatedBy = 1,
        //};
        //await service5.AddTag(tag);

        //var productTag = new ProductTag()
        //{
        //    TagID = 1,
        //    ProductID = 1,
        //};
        //await service5.AddProductTag(productTag);
        //service5.SaveChanges();
        #endregion

        //for (int i = 0; i < 10; i++)
        //{
        //    context.Categories.AddRange(
        //      new Category()  {
                  //ParentID = i,
                  //CategoryName = $"Electronics: {i}",
                  //CategoryDescription = "All kinds of electronic items",
                  //Icon = "electronics-icon.png",
                  //ImagePath = "images/electronics.png",
                  //IsActive = true,
        //      });
        //}

        //var categories = context.Categories;
        //foreach (var category in categories)
        //{
        //    var product = new Product()
        //    {
        //        ProductName = "Apple",
        //        SKU = "12345",
        //        RegularPrice = 100.00m,
        //        DiscountPrice = 80.00m,
        //        Quantity = 10,
        //        ShortDescription = "Short description of the product",
        //        ProductDescription = $"Detailed description of the product {category.CategoryID + 12}",
        //        ProductWeight = 1.5m,
        //        ProductNote = "Special note about the product",
        //        Published = true, 
        //    };
        //    product.Categories.Add(category);  //Category Add
        //    context.Products.Add(product);     //Then Product Add
        //}
        //context.SaveChanges();

        //Eager Loading
        //var categories = context.Categories.Include(r => r.Products).ToList();

        //foreach (var category in categories)
        //{
        //    Console.WriteLine($"{category.CategoryID} - {category.CategoryName}");
        //    foreach (var product in category.Products)
        //    {
        //        Console.WriteLine($"{product.ProductName}");
        //    }
        //}

        //Lazy Loading
        //var categories = context.Categories.ToList();
        //foreach (var category in categories)
        //{
        //    Console.WriteLine($"{category.CategoryID} - {category.CategoryName}");
        //    foreach(var product in category.Products)
        //    {
        //        Console.WriteLine($"{product.ProductName}");
        //    }
        //}

        //Explicit Loading
        //using Collection()
        //var categories = context.Categories.ToList();
        //foreach(var category in categories)
        //{
        //    Console.WriteLine($"{category.CategoryID} - {category.CategoryName}");
        //    context.Entry(category).Collection(c => c.Products).Load();
        //    foreach(var product in category.Products)
        //    {
        //        Console.WriteLine($"{product.ProductName}");
        //    }
        //}

        var cardService = new CardService(context);

        //var card = new Card()
        //{
        //    CustomerID = 1,
        //    CardItems = new List<CardItem>()
        //};
        //context.Cards.Add(card);
        //context.SaveChanges();

        //var product = context.Products.FirstOrDefault();
        //var lastProduct = context.Products.Skip(1).FirstOrDefault();

        //lastProduct.ProductWeight = 1;
        ////context.SaveChanges();
        //var product2 = context.Products.AsNoTracking().FirstOrDefault();

        //context.ChangeTracker.DetectChanges();
        //Console.WriteLine(context.ChangeTracker.DebugView.LongView);

        //var productState = context.Entry<Product>(product2).State;
        //Console.WriteLine($"product2 state: {productState}");

        //var productState2 = context.Entry<Product>(lastProduct).State;
        //Console.WriteLine($"lastProduct state: {productState2}");

        var product = new Product()
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
            Categories = new List<Category>()
            {
                new Category()
                {
                    ParentID = 2,
                    CategoryName = $"Electronics",
                    CategoryDescription = "All kinds of electronic items",
                    Icon = "electronics-icon.png",
                    ImagePath = "images/electronics.png",
                    IsActive = true,
                }
            }
        };

        Console.WriteLine(context.ChangeTracker.DebugView.LongView); //Hech narsa chiqmaydi chunki hech narsa ro'y bermaydi
        context.Attach(product);
        Console.WriteLine(context.ChangeTracker.DebugView.LongView); //Added state chiqadi chunki yangi productni changeTrackerga qo'shadi
        context.SaveChanges();
        Console.WriteLine(context.ChangeTracker.DebugView.LongView); //Unchanged state chiqadi chunki ChangeTracker yopiladi SaveChanges sababli


        Console.ReadLine();
    }
}