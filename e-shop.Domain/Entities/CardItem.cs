using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class CardItem : IAuditable
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
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public virtual Card Cards { get; set; }
    public virtual Product Products { get; set; }
}

