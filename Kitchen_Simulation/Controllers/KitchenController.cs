﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kitchen_Simulation.Models;

namespace Kitchen_Simulation.Controllers
{
    public class KitchenController
    {
        private Main View;
        private KitchenModel Model;

        //METHODS

        public void StartServerOrders()
        {
            NetworkManager.StartListeningOrders();
        }

        public KitchenController()
        {
            this.SetView(new Main());
            this.SetModel(new KitchenModel(this));
            
            //Lauching listening server for orders via Thread unmanaged
            Thread ServerSocket = new Thread(StartServerOrders);
            ServerSocket.Start();
        }

        public Main GetView()
        {
            return View;
        }

        public void SetView(Main value)
        {
            View = value;
        }

        public void Animation(string name)
        {
            this.GetView().GetSimulation().Animation(name);
        }

        public KitchenModel GetModel()
        {
            return Model;
        }

        public void SetModel(KitchenModel value)
        {
            Model = value;
        }

    }
}
