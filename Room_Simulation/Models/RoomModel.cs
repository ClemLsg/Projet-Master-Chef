using Kitchen_Simulation.Models;
using Room_Simulation.Controlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Room_Simulation.Models
{
    class RoomModel
    {
        private RoomController _Controller;

        public RoomModel(RoomController controller)
        {
            this.SetController(controller);
            this.Main();
        }

        internal RoomController GetController()
        {
            return _Controller;
        }

        internal void SetController(RoomController value)
        {
            _Controller = value;
        }

        public void Main()
        {
            List<ClientGroup> clientGroups = new List<ClientGroup>();
            List<Square> squares = new List<Square>();
            List<Client> clients = new List<Client>();
            Client client = new Client();
            Client client2 = new Client();
            Client client3 = new Client();
            client.MakeAnOrder("HardEgg", "Tartiflette", "BananaSplit");
            client2.MakeAnOrder("Gaspatcho", "ForestChicken", "FruitsSalad");
            client3.MakeAnOrder("TomatoSoup", "Omelette", "BananaSplit");
            clients.Add(client);
            clients.Add(client2);
            clients.Add(client3);

            Square square = new Square();
            Square square2 = new Square();

            Table table = new Table(5);
            Table table2 = new Table(10);

            HeadWaiter headWaiter1 = new HeadWaiter(square);
            HeadWaiter headWaiter2 = new HeadWaiter(square2);

            square.HeadWaiters = headWaiter1;
            square2.HeadWaiters = headWaiter2;

            square.AddTables(table);
            square2.AddTables(table2);
            squares.Add(square);
            squares.Add(square2);
            Room room = new Room();
            room.AddSquare(square);
            room.AddSquare(square2);

            ClientGroup clientGroup = new ClientGroup(clients, 10, 10, 10);
            clientGroups.Add(clientGroup);
            Butler butler = new Butler();
            butler.Room = room;

            

            Thread threadWaterBread = new Thread(NeedWaterBread);
            threadWaterBread.Start();

            foreach (ClientGroup cg in clientGroups)
            {
                Thread threadManage = new Thread(() => ManageClient(cg));
                threadManage.Start();
            }


            void ManageClient(ClientGroup cg)
            {
                if (cg.Seated == false)
                {
                    HeadWaiter headwaiter = butler.AssignTable(cg, cg.table);
                    headwaiter.GiveMenu(cg.table);

                    
                   //Thread.Sleep(300000);
                    
                    foreach (Client c in cg.Clients)
                    {

                        Order order = headwaiter.TakeOrder(c, cg.table);
                        headwaiter.BringOrder(order, cg.table);
                    }
                    //Send order by sockets
                }

                Square tablesquare = new Square();
                foreach (Square sq in squares)
                {
                    foreach (Table t in sq.Tables)
                    {
                        if (t == cg.table)
                        {
                            tablesquare = sq;
                        }
                    }


                    Waiter waiter = new Waiter(tablesquare);
                    //Receive recipes by sockets
                    waiter.ServeOrder(cg);
                    client.Eat();
                    int totaltime = cg.TimeToEatStarter + cg.TimeToEatMain + cg.TimeToEatDessert;

                    //Thread.Sleep(totaltime);

                    client.Pay();
                    table.IsDirty();
                    waiter.CLeanTable(cg.table);

                }
            }

            void NeedWaterBread()
            {
                bool loop = true;

                RoomClerk roomClerk = new RoomClerk(squares);
                while(loop)
                {
                    roomClerk.serveDrink();
                    roomClerk.serveBread();
                }
            }
        }
        

    }
}
