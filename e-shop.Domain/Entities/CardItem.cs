using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class CardItem
{
    public int CardItemID { get; set; }
    public int CardID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
}

