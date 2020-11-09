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
                bayi.BayiTel = data[4].ToString();
                bayilerList.Add(bayi);
            }
            sqlConnection.Connection().Close();

            datagrid.DataSource = bayilerList;

        }


        public Boolean BayiKontrol(String bayiID)
        {

            sqlConnection.Connection().Open();
            SqlCommand urunKontrol = new SqlCommand("select bayiID from tblBayiler", sqlConnection.Connection());
            SqlDataReader data = urunKontrol.ExecuteReader();
            while (data.Read())
            {
                if (bayiID == data[0].ToString())
                {
                    sqlConnection.Connection().Close();
                    return true;
                }
            }
            sqlConnection.Connection().Close();
            return false;

        }

        public Bayi BayiGetir(String Id)
        {
            Bayi seciliBayi = new Bayi();

            sqlConnection.Connection().Open();
            SqlCommand seciliBayigetir = new SqlCommand("select * from tblBayiler where BayiID = @p1", sqlConnection.Connection());
            seciliBayigetir.Parameters.AddWithValue("@p1", Id);
            SqlDataReader data = seciliBayigetir.ExecuteReader();
            while (data.Read())
            {

                seciliBayi.BayiId = data[0].ToString();
                seciliBayi.BayiAd = data[1].ToString();
                seciliBayi.BayiEposta = data[2].ToString();
                seciliBayi.BayiAdres = data[3].ToString();
                seciliBayi.BayiTel = data[4].ToString();

            }
            sqlConnection.Connection().Close();

            return seciliBayi;
        }



        public void BayiGuncelle(string ıd, String ad, String eposta, string adres,String tel)
        {

            sqlConnection.Connection().Open();
            SqlCommand bayiGuncelle = new SqlCommand("UPDATE tblBayiler SET bayiAd=@p1,bayiEposta=@p2,bayiAdres=@p3,bayiTel=@p4  WHERE bayiID=@p0", sqlConnection.Connection());
            bayiGuncelle.Parameters.AddWithValue("@p0", ıd);
            bayiGuncelle.Parameters.AddWithValue("@p1", ad);
            bayiGuncelle.Parameters.AddWithValue("@p2", eposta);
            bayiGuncelle.Parameters.AddWithValue("@p3", adres);
            bayiGuncelle.Parameters.AddWithValue("@p4", tel);
            bayiGuncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }


        public void BayiSil(String ıd)
        {

            sqlConnection.Connection().Open();
            SqlCommand bayiSil = new SqlCommand("DELETE tblBayiler WHERE bayiID=@p1", sqlConnection.Connection());
            bayiSil.Parameters.AddWithValue("@p1", ıd);
            bayiSil.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }




    }
}
