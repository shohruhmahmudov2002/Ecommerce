using e_shop.DataAccess.Services;
using e_shop.DataAccess;
using e_shop.Domain.Entities;

namespace e_shop.console;
internal class Program
{
    static async Task Main(string[] args)
    {
        using var context = new ShopContext();

        //var service = new ProductService(context);

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

        //var service2 = new CategoryService(context);
        //service2.Add(new Category()
        //{
        //    ParentID = 1,
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

        var service3 = new CustomerService(context);
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

        var service4 = new CardService(context);
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


        Console.Read();
    }
}

