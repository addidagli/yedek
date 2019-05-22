using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineBookStore
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-9FKNVJM\\SQLEXPRESS;Initial Catalog=OnlineBookStoreDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
