using System;
using Kitchen_Simulation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KitchenTests
{
    [TestClass]
    public class SqlConnectorTests
    {
        [TestMethod]
        public void testConnect()
        {
            SQLConnector sqlconnector = new SQLConnector();
            Assert.AreEqual(true,sqlconnector.Connect("KEVIN\\SQLEXPRESS"));
        }
    }
}
