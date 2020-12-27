using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimBakimi
{
    class ProductOperations
    {
        SQlConnection sqlConnection = new SQlConnection();


        public void UrunEkle(String urunAd,long stok,Double birimFiyat) {

            sqlConnection.Connection().Open();
            SqlCommand productAdd = new SqlCommand(" insert into tblurunler (urunAd,urunStok,urunBirimFiyat) values(@P1,@P2,@P3)", sqlConnection.Connection());
            productAdd.Parameters.AddWithValue("@p1", urunAd);
            productAdd.Parameters.AddWithValue("@p2", stok);
            productAdd.Parameters.AddWithValue("@p3", birimFiyat);
            productAdd.ExecuteNonQuery();  
            sqlConnection.Connection().Close();
        
        }

        public Boolean UrunKontrol(String urunıID){

            sqlConnection.Connection().Open();
            SqlCommand urunKontrol = new SqlCommand("select urunID from tblurunler", sqlConnection.Connection());
            SqlDataReader data = urunKontrol.ExecuteReader();
            while (data.Read())
            {
                if (urunıID == data[0].ToString())
                {
                    sqlConnection.Connection().Close();
                    return true;
                }
            }
            sqlConnection.Connection().Close();
            return false;
        
        }


        public void UrunleriGetir(DataGridView datagrid) {
  
            List<UrunModel> urunlerList=new List<UrunModel>();

            sqlConnection.Connection().Open();
            SqlCommand urungetir = new SqlCommand("select * from tblurunler", sqlConnection.Connection());
            SqlDataReader data = urungetir.ExecuteReader();
            while (data.Read())
            {
                UrunModel urun = new UrunModel();
                urun.UrunID = data[0].ToString();
                urun.UrunAdi = data[1].ToString();
                urun.urunStok = data[2].ToString();
                urun.urunBirimFiyat = (float)Double.Parse(data[3].ToString());
                urunlerList.Add(urun);
            }
            sqlConnection.Connection().Close();

            datagrid.DataSource = urunlerList;
        
        }

        public UrunModel urunGetir(String Id) {
            UrunModel seciliUrun=new UrunModel();

            sqlConnection.Connection().Open();
            SqlCommand seciliUrungetir = new SqlCommand("select * from tblurunler where urunID = @p1", sqlConnection.Connection());
            seciliUrungetir.Parameters.AddWithValue("@p1", Id);
            SqlDataReader data = seciliUrungetir.ExecuteReader();
            while (data.Read()) {

                seciliUrun.UrunID = data[0].ToString();
                seciliUrun.UrunAdi = data[1].ToString();
                seciliUrun.urunStok = data[2].ToString();
                seciliUrun.urunBirimFiyat = (float)Double.Parse(data[3].ToString());

            }
            sqlConnection.Connection().Close();

            return seciliUrun;
        }


        public void urunGuncelle(string ıd,String urunAd,String stok, string fiyat) {

            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblurunler SET urunAd=@p1,urunStok=@p2,urunBİrimFiyat=@p3  WHERE urunID=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0", ıd);
            urunguncelle.Parameters.AddWithValue("@p1", urunAd);
            urunguncelle.Parameters.AddWithValue("@p2", stok);
            urunguncelle.Parameters.AddWithValue("@p3",Convert.ToDouble(fiyat));
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }
        public void urunSil(String ıd) {

            sqlConnection.Connection().Open();
            SqlCommand urunSil = new SqlCommand("DELETE tblurunler WHERE urunID=@p1", sqlConnection.Connection());
            urunSil.Parameters.AddWithValue("@p1", ıd);
            urunSil.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }


        public void urunStokGuncelleId(String UrunId,String miktar) {
            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblurunler SET urunStok+=@p1 WHERE urunID=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0", UrunId);
            urunguncelle.Parameters.AddWithValue("@p1", miktar);        
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();
        }
        public void urunStokGuncelleAd(String UrunId, String miktar)
        {
            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblurunler SET urunStok+=@p1 WHERE urunAd=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0", UrunId);
            urunguncelle.Parameters.AddWithValue("@p1", miktar);
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();
        }



    }



    
}
