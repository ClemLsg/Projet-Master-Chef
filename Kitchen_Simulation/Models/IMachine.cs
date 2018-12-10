using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    interface IMachine
    {
        bool GetIsWashing();
        void SetIsWashing(bool value);
        void Wash();
 
    }
}
