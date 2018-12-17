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

            Table table = new Table(1,8);
            Table table2 = new Table(2,8);
            Table table3 = new Table(3,10);
            Table table4 = new Table(4,10);
            Table table5 = new Table(5,6);
            Table table6 = new Table(6,6);
            Table table7 = new Table(7,8);
            Table table8 = new Table(8,8);
            Table table9 = new Table(9,8);
            Table table10 = new Table(10,4);
            Table table11 = new Table(11,4);
            Table table12 = new Table(12,6);
            Table table13 = new Table(13,6);
            Table table14 = new Table(14,6);
            Table table15 = new Table(15,4);
            Table table16 = new Table(16,4);
            Table table17 = new Table(17,4);
            Table table18 = new Table(18,4);
            Table table19 = new Table(19,4);
            Table table20 = new Table(20,2);
            Table table21 = new Table(21,2);
            Table table22 = new Table(22,2);
            Table table23 = new Table(23,4);
            Table table24 = new Table(24,4);
            Table table25 = new Table(25,4);
            Table table26 = new Table(26,2);
            Table table27 = new Table(27,2);
            Table table28 = new Table(28,2);
            Table table29 = new Table(29,2);
            Table table30 = new Table(30,2);
            Table table31 = new Table(31,2);
            Table table32 = new Table(32,2);

            HeadWaiter headWaiter1 = new HeadWaiter(square);
            HeadWaiter headWaiter2 = new HeadWaiter(square2);

            square.HeadWaiters = headWaiter1;
            square2.HeadWaiters = headWaiter2;

            square.AddTables(table);
            square.AddTables(table2);
            square.AddTables(table3);
            square.AddTables(table4);
            square.AddTables(table5);
            square.AddTables(table6);
            square.AddTables(table7);
            square.AddTables(table8);
            square.AddTables(table9);
            square.AddTables(table10);
            square2.AddTables(table11);
            square2.AddTables(table12);
            square2.AddTables(table13);
            square2.AddTables(table14);
            square2.AddTables(table15);
            square2.AddTables(table16);
            square2.AddTables(table17);
            square2.AddTables(table18);
            square2.AddTables(table19);
            square2.AddTables(table20);
            square2.AddTables(table21);
            square2.AddTables(table22);
            square2.AddTables(table23);
            square2.AddTables(table24);
            square2.AddTables(table25);
            square2.AddTables(table26);
            square2.AddTables(table27);
            square2.AddTables(table28);
            square2.AddTables(table29);
            square2.AddTables(table30);
            square2.AddTables(table31);
            square2.AddTables(table32);

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
