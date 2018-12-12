using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TestSocket
{
    class Program
    {
        [Serializable]
        public class Order
        {
            public string Starter { get; set; }
            public string Main { get; set; }
            public string Dessert { get; set; }

            public Order(string starter, string main, string dessert)
            {
                this.Starter = starter;
                this.Main = main;
                this.Dessert = dessert;
            }
        }
        public static void StartClient()
        {
            NetworkManager.StartClient(new Order("bite","chatte","couille"));
        }
        public static void StartServer()
        {
            NetworkManager.StartListening();
        }
        static void Main(string[] args)
        {
            Thread threadx = new Thread(StartServer);
            threadx.Start();

            Thread.Sleep(1000);

            Thread thread1 = new Thread(StartClient);
            thread1.Start();

        }


    }
}
