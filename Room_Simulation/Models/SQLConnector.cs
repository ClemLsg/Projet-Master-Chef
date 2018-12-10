using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Kitchen_Simulation.Models
{
    public class SQLConnector
    {
        public static SQLConnector Instance { get; set; }

        public bool Connect(string db)
        {
            bool connected = false;

            try
            {
                string cnx = "Data Source='" + db + "';Initial Catalog=DB_A2_WS2;Integrated Security=SSPI;";
                SqlConnection SqlConnection = new SqlConnection();
                SqlCommand sqlCommand = new SqlCommand();
                SqlConnection.ConnectionString = cnx;
                SqlConnection.Open();
                connected = true;
            }
            catch
            {
                
            }
            return connected;
        }

        public ConnectionState Disconnect(SqlConnection connection)
        {
            connection.Close();
            return connection.State;
        }
    }
}
