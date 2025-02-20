using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess.Services;
public class ProductTagService
{
    private readonly ShopContext _context;
    public ProductTagService(ShopContext context)
    {
        _context = context;
    }
    public async Task AddTag(Tag tags)
    {
        await _context.Tags.AddAsync(tags);
    }
    public async Task AddProduct(Product product)
    {
        await _context.Products.AddAsync(product);
    }
    public async Task AddProductTag(ProductTag productTag)
    {
        await _context.ProductTags.AddAsync(productTag);
    }

    public IEnumerable<Product> GetProduct()
    {
        return _context.Products
            .Include(r => r.ProductTags)
            .ThenInclude(r => r.Tags);
    }
    public int SaveChanges() => _context.SaveChanges();
}

