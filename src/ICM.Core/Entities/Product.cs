﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;
public class Product : BaseEntity
{
  public string ProductName { get; set; }
  public decimal Price { get; set; }
  public ProductDetail ProductDetail { get; set; }
  public decimal NoOfStock { get; set; }
  public string Status { get; set; } = "Active";
}
