using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;
public class Inventory : BaseEntity
{
  public Product Product { get; set; }
  public decimal AvailableStock { get; set; }
}
