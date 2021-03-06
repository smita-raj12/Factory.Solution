using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set;}
    public DateTime JoinDate { get; set; }
    public string Active { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get;}
  }
}