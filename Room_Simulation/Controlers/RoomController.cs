using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Room_Simulation.Models;

namespace Room_Simulation.Controlers
{
    public class RoomController
    {
        private Main _View;
        private RoomModel _Model;

        public RoomController()
        {
            this.SetView(new Main());
            this.SetModel(new RoomModel(this));
        }

        public Main GetView()
        {
            return _View;
        }

        public void SetView(Main value)
        {
            _View = value;
        }

        internal RoomModel GetModel()
        {
            return _Model;
        }

        internal void SetModel(RoomModel value)
        {
            _Model = value;
        }

        public void Animation(string name)
        {
            this.GetView().GetSimulation().Animation(name);
        }
    }
}
