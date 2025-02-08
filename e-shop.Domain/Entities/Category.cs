using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("category_id")]
    public int CategoryID { get; set; }
    [Column("parent_id")]
    public int ParentID { get; set; }
    [Column("category_name")]
    [Required]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Category name exceeded the limit")]
    //[MaxLength(50, ErrorMessage = "Category name exceeded the limit")]
    public string? CategoryName { get; set; }
    [Column("category_description")]
    public string CategoryDescription { get; set; }
    [Column("icon")]
    public string Icon {  get; set; }
    [Column("image_path")]
    public string ImagePath { get; set; }
    [Column("is_active")]
    public bool IsActive { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [Column("created_by")]
    public int CreatedBy { get; set; }
    [Column("updated_by")]
    public int UpdatedBy { get; set; }
}

