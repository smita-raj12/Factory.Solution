using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string MachineType { get; set; }    
    public string Operational { get; set; }
    public DateTime  InspectionDate {get; set;}  
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}