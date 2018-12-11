using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public abstract class Machine
    {
        public bool IsWashing { get; set; } = false;

        public void Wash(List<Tool> tools)
        {
            this.IsWashing = true;
            foreach (var tool in tools)
            {
                tool.IsFree = true;
            }

            this.IsWashing = false;
        }
    }
}
