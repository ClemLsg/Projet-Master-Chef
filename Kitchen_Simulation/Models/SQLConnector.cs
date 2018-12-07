using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Kitchen_Simulation.Models
{
    class SQLConnector
    {
        internal static SQLConnector Instance { get; set; }

        public void Connect(string db)
        {
            string cnx = "Data Source='" + db + "';Initial Catalog=DB_A2_WS2;Integrated Security=SSPI;";
            SqlConnection SqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection.ConnectionString = cnx;
            SqlConnection.Open();
        }

        public void Disconnect(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
