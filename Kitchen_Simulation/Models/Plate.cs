using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Recipes;

namespace Kitchen_Simulation.Models
{
    class Plate
    {
        public Recipe Recipe { get; private set; } = null;
        
        public Plate(Recipe recipe)
        {
            this.Recipe = recipe;
        }
    }
}
