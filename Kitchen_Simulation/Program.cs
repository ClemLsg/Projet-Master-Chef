using System;
using Kitchen_Simulation.Controllers;

namespace Kitchen_Simulation
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///

        [STAThread]
        static void Main()
        {
            var controller = new KitchenController();
            controller.GetView().Run();
        }
    }
#endif
}
