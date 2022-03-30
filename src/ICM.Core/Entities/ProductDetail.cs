using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;
public class ProductDetail : BaseEntity
{
  public string Details { get; set; } //TODO: To be changed with other properties 
  public virtual Product Product { get; set; }
  public string ProductCode { get; set; }
  public string Description { get; set; }
  public string  Type { get; set; }

}
