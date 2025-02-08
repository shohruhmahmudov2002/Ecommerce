using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Gallery
{
    public int GalleryID { get; set; }
    public int ProductID { get; set; }
    public string ImagePath { get; set; }
    public bool Thumbnail { get; set; }
    public int DisplayOrder {  get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
}

