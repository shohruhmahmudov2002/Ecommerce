using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Card
{
    public Card()
    {
        CardItems = new List<CardItem>();
    }
    [Key]
    public int CardID { get; set; }
    [Required]
    [ForeignKey(nameof(Customer))]
    public int CustomerID { get; set; }
    public Customer Customers { get; set; }
    public ICollection<CardItem> CardItems { get; set; }
}

