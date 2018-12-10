using System;
using Kitchen_Simulation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

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

        [TestMethod]
        public void testDisconnect()
        {
            SQLConnector sqlconnector = new SQLConnector();
            string db = "KEVIN\\SQLEXPRESS";
            string cnx = "Data Source='" + db + "';Initial Catalog=DB_A2_WS2;Integrated Security=SSPI;";
            SqlConnection SqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection.ConnectionString = cnx;
            SqlConnection.Open();
            Assert.AreEqual(System.Data.ConnectionState.Closed, sqlconnector.Disconnect(SqlConnection));
        }
    }
}
