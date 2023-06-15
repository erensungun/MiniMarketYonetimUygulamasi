using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mini_Market_Veritabanı
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=EREN;Initial Catalog=EcemMarket;Integrated Security=True");

        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
