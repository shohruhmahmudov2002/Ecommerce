using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class AttributeValue
{
    public int AttributeValueID { get; set; }
    public int AttributeID { get; set; }
    public string AttributValue { get; set; }
    public string Color { get; set; }
}

