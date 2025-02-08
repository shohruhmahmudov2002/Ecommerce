﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class OrderItem
{
    public int OrderItemID { get; set; }
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int ShippingID { get; set; }
}

