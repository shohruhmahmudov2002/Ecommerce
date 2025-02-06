﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Category
{
    public int CategoryID { get; set; }
    public int ParentID { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string Icon {  get; set; }
    public string ImagePath { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
}

