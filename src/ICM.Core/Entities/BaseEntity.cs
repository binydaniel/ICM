using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Core.Entities;

public class BaseEntity
{
  public virtual Guid Id { get; protected set; }
  public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
  public virtual DateTime GetDateTime { get; set; } = DateTime.Now;

}
