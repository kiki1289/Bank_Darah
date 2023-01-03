using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Bank_Darah
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-27AG9DA;Initial Catalog=Bank_Darah;Integrated Security=True");
            return Conn;
        }

    }
}
