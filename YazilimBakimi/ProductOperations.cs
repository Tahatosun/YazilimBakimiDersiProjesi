using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace YazilimBakimi
{
    class ProductOperations
    {
        SQlConnection sqlConnection = new SQlConnection();


        public void UrunEkle(String urunAd,long stok,long birimFiyat) {

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




    }
}
