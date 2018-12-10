using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public class KitchenModel
    {
        private Cleaner _cleaner;
        private readonly List<KitchenClerk> _kitchenClerks;
        private Cook _cook;
        private readonly List<Tool> _tools = new List<Tool>();
        public DishWasher DishWasher { get; } = new DishWasher();

        public KitchenModel()
        {
            this._cleaner = new Cleaner(this);
            
            this._kitchenClerks = new List<KitchenClerk>
            {
                new KitchenClerk(),
                new KitchenClerk()
            };

            this._cook = new Cook(this._kitchenClerks, this._tools, this._cleaner);
        }
        
    }
}
