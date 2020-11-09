using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimBakimi
{
    class DealerOperations
    {
        SQlConnection sqlConnection = new SQlConnection();
        

        public void bayiEkle(String bayiAd,String bayiEposta, String bayiTel,String bayiAdres) {

            sqlConnection.Connection().Open();
            SqlCommand productAdd = new SqlCommand(" insert into tblBayiler (BayiAd,bayiEposta,bayiAdres,bayiTel) values(@P1,@P2,@P3,@p4)", sqlConnection.Connection());
            productAdd.Parameters.AddWithValue("@p1", bayiAd);
            productAdd.Parameters.AddWithValue("@p2", bayiEposta);
            productAdd.Parameters.AddWithValue("@p3", bayiAdres);
            productAdd.Parameters.AddWithValue("@p4", bayiTel);
            productAdd.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }


        public void bayileriGetir(DataGridView datagrid) {
            List<Bayi> bayilerList = new List<Bayi>();

            sqlConnection.Connection().Open();
            SqlCommand urungetir = new SqlCommand("select * from tblBayiler", sqlConnection.Connection());
            SqlDataReader data = urungetir.ExecuteReader();
            while (data.Read())
            {
                Bayi bayi = new Bayi();
                bayi.BayiId = data[0].ToString();
                bayi.BayiAd = data[1].ToString();
                bayi.BayiEposta = data[2].ToString();
                bayi.BayiAdres = data[3].ToString();
                bayi.BatiTel = data[4].ToString();
                bayilerList.Add(bayi);
            }
            sqlConnection.Connection().Close();

            datagrid.DataSource = bayilerList;



        }


    }
}
