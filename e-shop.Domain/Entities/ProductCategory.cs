using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class ProductCategory
{
    public int CategoryID { get; set; }
    public int ProductID { get; set; }

    public virtual Category Categories { get; set; }
    public virtual Product Products { get; set; }
}

