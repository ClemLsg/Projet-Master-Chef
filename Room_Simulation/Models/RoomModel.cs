using Kitchen_Simulation.Models;
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
            


            ClientGroup clientGroup = new ClientGroup(clients, 10, 10, 10);
            clientGroups.Add(clientGroup);
            Butler butler = new Butler();

            Thread threadManage = new Thread(ManageClient);
            threadManage.Start();

            Thread threadWaterBread = new Thread(NeedWaterBread);
            threadWaterBread.Start();

            void ManageClient()
            {
                foreach (ClientGroup cg in clientGroups)
                {
                    if (cg.Seated == false)
                    {
                        HeadWaiter headwaiter = butler.AssignTable(cg);
                        headwaiter.GiveMenu(cg.table);

                        Thread.Sleep(300000);

                        foreach (Client c in cg.Clients)
                        {

                            Order order = headwaiter.TakeOrder(c);
                            headwaiter.BringOrder(order);
                        }
                        //Send order by sockets
                    }

                    Square tablesquare = new Square();
                    foreach (Square square in squares)
                    {
                        foreach (Table t in square.Tables)
                        {
                            if (t == cg.table)
                            {
                                tablesquare = square;
                            }
                        }


                        Waiter waiter = new Waiter(tablesquare);
                        //Receive recipes by sockets
                        waiter.ServeOrder(cg);
                        int totaltime = cg.TimeToEatStarter + cg.TimeToEatMain + cg.TimeToEatDessert;

                        Thread.Sleep(totaltime);

                        client.Pay();
                        waiter.CLeanTable(cg.table);

                    }
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
