using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class VariantValue
{
    public int VariantValueID { get; set; }
    public int VariantID { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

