using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models 
{
    class DishWasher : IMachine
    {
        private bool IsWashing;

        public bool GetIsWashing()
        {
            return IsWashing;
        }

        public void SetIsWashing(bool value)
        {
            IsWashing = value;
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }
    }
}
