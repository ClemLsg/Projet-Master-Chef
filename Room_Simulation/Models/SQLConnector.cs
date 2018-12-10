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


        public ConnectionState Connect(string db)
        {
            SqlConnection SqlConnection = new SqlConnection();

            try
            {
                string cnx = "Data Source='" + db + "';Initial Catalog=DB_A2_WS2;Integrated Security=SSPI;";
                SqlCommand sqlCommand = new SqlCommand();
                SqlConnection.ConnectionString = cnx;
                SqlConnection.Open();
            }
            catch
            {

            }
            return SqlConnection.State;
        }

        public ConnectionState Disconnect(SqlConnection connection)
        {
            connection.Close();
            return connection.State;
        }
    }
}
