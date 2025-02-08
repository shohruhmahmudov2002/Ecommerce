﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Product
{
    [Key]
    [Column("product_id")]
    public int ProductID { get; set; }
    [Column("product_name")]
    public string ProductName { get; set; }
    [Column("sku")]
    public string SKU { get; set; }
    [Column("regular_price")]
    public decimal RegularPrice { get; set; }
    [Column("discount_price")]
    public decimal DiscountPrice { get; set; }
    [Column("quantity")]
    public int Quantity { get; set; }
    [Column("short_description")]
    public string ShortDescription { get; set; }
    [Column("product_description")]
    public string ProductDescription { get; set; }
    [Column("product_weight")]
    public decimal ProductWeight { get; set; }
    [Column("product_note")]
    public string ProductNote { get; set; }
    [Column("published")]
    public bool Published { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [Column("created_by")]
    public int CreatedBy { get; set; }
    [Column("updated_by")]
    public int UpdatedBy { get; set; }
}

