using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Order
{
    public int OrderID { get; set; }
    public int CouponID { get; set; }
    public int CustomerID { get; set; }
    public int OrderStatusID { get; set; }
    public DateTime OrderApprovedAt { get; set; }
    public DateTime OrderDeliveredCarrierDate { get; set; }
    public DateTime OrderDeliveredCustomerDate { get; set; }
    public DateTime CreatedAt { get; set; }
}

