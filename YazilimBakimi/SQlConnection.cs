using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazilimBakimi
{
    class SQlConnection
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7OCD4IRC\\SQLEXPRESS;Initial Catalog=dtbYazilimBakimi;Integrated Security=True");

        public SqlConnection Connection() {
            return baglanti;
        }

        

    }
}
