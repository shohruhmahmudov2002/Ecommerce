using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class CardItem
{
    [Key]
    public int CardItemID { get; set; }
    [Required]
    [ForeignKey(nameof(Card))]
    public int CardID { get; set; }
    [Required]
    [ForeignKey(nameof(Product))]
    public int ProductID { get; set; }
    [Required]
    public int Quantity { get; set; }
    public Card Cards { get; set; }
    public Product Products { get; set; }
}

