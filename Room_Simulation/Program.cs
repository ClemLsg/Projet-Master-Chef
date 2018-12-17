using System;

namespace Room_Simulation
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var controller = new Controlers.RoomController();

            controller.GetView().Run();
        }
    }
#endif
}
