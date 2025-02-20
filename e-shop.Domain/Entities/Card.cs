using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Card : IAuditable
{
    public Card()
    {
        CardItems = new List<CardItem>();
    }
    public int CardID { get; set; }
    public int CustomerID { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public virtual Customer Customers { get; set; }
    public virtual ICollection<CardItem> CardItems { get; set; }
}

