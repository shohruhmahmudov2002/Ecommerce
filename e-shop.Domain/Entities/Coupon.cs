using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Coupon
{
    public int CouponID { get; set; }
    public string Code { get; set; }
    public string CouponDescription { get; set; }
    public decimal Discount { get; set; }
    public string DiscountType { get; set; }
    public int TimesUsage { get; set; }
    public int MaxUsage { get; set; }
    public DateTime CouponStartDate { get; set; }
    public DateTime CouponEndDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
}

