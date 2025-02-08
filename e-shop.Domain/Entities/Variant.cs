using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Variant
{
    public int VariantID { get; set; }
    public int VariantAttributeValueID { get; set; }
    public int ProductID { get; set; }
}

