﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;
public class Category
{
  public string CategoryName { get; set; }
  public string Description { get; set; }
  public string Status { get; set; } = "Active";
}
