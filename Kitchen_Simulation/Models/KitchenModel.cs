using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    class KitchenModel
    {
        internal List<IMachine> Machines { get; set; }
        internal Chef Chef { get; set; }
        internal List<Cook> Cooks { get; set; }
        internal List<Cleaner> Cleaners { get; set; }
        internal List<Plate> Plates { get; set; }
    }
}
