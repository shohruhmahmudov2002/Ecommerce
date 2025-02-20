using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class ProductTag
{
    public int TagID { get; set; }
    public int ProductID { get; set; }

    public virtual Tag Tags { get; set; }
    public virtual Product Products { get; set; }
}

