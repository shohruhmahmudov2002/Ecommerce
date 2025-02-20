using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DataAccess.ModelConfiguration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(r => r.ProductID);

        builder.Property(p => p.SKU)
        .HasMaxLength(255)
        .IsRequired();

        builder.Property(p => p.ProductName)
        .HasMaxLength(255)
        .HasColumnName("product_name")
        .HasColumnType("text")
        .IsRequired();

        builder.Property(p => p.RegularPrice)
        .HasDefaultValue(0)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(p => p.UpdatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasMany(r => r.Categories)
            .WithMany(r => r.Products);
    }
}

//public class ProductCategoryConfiguration : IEntityTypeConfiguration<Product>
//{
//    public void Configure(EntityTypeBuilder<Product> builder)
//    {
//        builder.HasKey(r => new { r.ProductID, r.CategoryID });

//        builder.HasOne(r => r.Product)
//            .WithMany(r => r.Categories)
//            .HasForeignKey(r => r.ProductID);

//        builder.HasOne(r => r.Categories)
//            .WithMany(r => r.Product)
//            .HasForeignKey(r => r.CategoryID);
//    }
//}

public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> builder)
    {
        builder.HasKey(r => new { r.ProductID, r.TagID });

        builder.HasOne(r => r.Tags)
            .WithMany(r => r.ProductTags)
            .HasForeignKey(r => r.TagID);

        builder.HasOne(r => r.Products)
            .WithMany(r => r.ProductTags)
            .HasForeignKey(r => r.ProductID);
    }
}
