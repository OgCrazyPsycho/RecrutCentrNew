using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutCentr
{
    internal class DataBase
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-OOKRQ4Q;Initial Catalog=RecrutCentr;Integrated Security=True;"); 

        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public SqlConnection getConnect()
        {
            return connect;
        }


    }
}
