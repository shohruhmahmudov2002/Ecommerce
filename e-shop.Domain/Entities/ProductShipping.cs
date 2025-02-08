using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class ProductShipping
{
    public int ProductID { get; set; }
    public int ShippingID { get; set; }
    public decimal ShipCharge { get; set; }
    public bool IsFree { get; set; }
    public decimal EstimatedDays { get; set; }
}

