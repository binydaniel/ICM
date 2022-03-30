﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;
public class User:BaseEntity
{
  public string Name { get; set; }
  public string Email { get; set; }
  public DateTime DoB { get; set; }
  public string Status { get; set; } = "Active";
}
