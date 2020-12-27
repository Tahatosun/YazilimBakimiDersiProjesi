using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimBakimi
{
    class OrderProcessing
    {
        public String sipariId;
        SQlConnection sqlConnection = new SQlConnection();

        ProductOperations productOperations = new ProductOperations();



        public void UrunlerComboboxItemsAdd(ComboBox urunlerComboBox,List<UrunModel> urunlist)
        {
       
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
                urunlist.Add(urun);
                urunlerComboBox.Items.Add(urun.UrunAdi);

            }
            sqlConnection.Connection().Close();
        }

        public void cmbBxSiparisiVerenBayiItemsAdd(ComboBox cmbBxSiparisiVerenBayi, List<Bayi> bayiList)
        {           
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
                bayiList.Add(bayi);
                cmbBxSiparisiVerenBayi.Items.Add(bayi.BayiAd);
            }
            sqlConnection.Connection().Close();
        }

        public void dataGridSipariseAitUrunleriGetir(DataGridView dataGridView, List<SiparisDetayModel> siparisDetaylistesi) {   
            dataGridView.DataSource = siparisDetaylistesi;
        }

        public void SipariseUrunEkle(List<UrunModel> urunlist,List<SiparisDetayModel> siparisListesi, String urunAdi, String seciliUrun, String numUrunAdeti, float urunFiyat )
        {
            SiparisDetayModel eklenecekUrun = new SiparisDetayModel();       
            eklenecekUrun.urunAdı1 = urunAdi;
            eklenecekUrun.UrunId = seciliUrun;
            eklenecekUrun.UrunAdet = numUrunAdeti;
            eklenecekUrun.DetayFiyat = urunFiyat*Convert.ToInt32(numUrunAdeti) ;
            siparisListesi.Add(eklenecekUrun);           
        }

        public void SiparisOlustur(String Bayi,Double siparisTutarı,List<SiparisDetayModel> siparisListesi) {

           
            sqlConnection.Connection().Open();
            SqlCommand orderAdd = new SqlCommand(" insert into tblSiparisler (bayiId,siparisTarih,siparisTutar) values(@P1,@P2,@P3)", sqlConnection.Connection());
            orderAdd.Parameters.AddWithValue("@p1", Bayi);
            orderAdd.Parameters.AddWithValue("@p2", DateTime.Now);
            orderAdd.Parameters.AddWithValue("@p3", siparisTutarı);
            orderAdd.ExecuteNonQuery();
            sqlConnection.Connection().Close();


            sqlConnection.Connection().Open();
            SqlCommand orderId = new SqlCommand("select * from tblSiparisler", sqlConnection.Connection());
            SqlDataReader data = orderId.ExecuteReader();
            while (data.Read())
            {
                sipariId = data[0].ToString(); 
            }
            sqlConnection.Connection().Close();


          
            foreach (SiparisDetayModel model in siparisListesi) {
                sqlConnection.Connection().Open();
                SqlCommand orderDetailAdd = new SqlCommand(" insert into tblSiparisDetay (siparisID,urunID,urunAdet,detayFiyat) values(@P1,@P2,@P3,@p4)", sqlConnection.Connection());
                orderDetailAdd.Parameters.AddWithValue("@p1", sipariId);
                orderDetailAdd.Parameters.AddWithValue("@p2", model.UrunId);
                orderDetailAdd.Parameters.AddWithValue("@p3", model.UrunAdet);
                orderDetailAdd.Parameters.AddWithValue("@p4",model.DetayFiyat);
                orderDetailAdd.ExecuteNonQuery();
                sqlConnection.Connection().Close();

                productOperations.urunStokGuncelleId(model.UrunId, "-"+model.UrunAdet);

            }
         
     
          
        }

        public Double siparisTutarıHesapla(List<SiparisDetayModel> siparisListesi)
        {
            Double siparisTutari = 0;
            foreach (SiparisDetayModel siparis in siparisListesi)
            {
                siparisTutari += Double.Parse(siparis.DetayFiyat.ToString());
            }
            return siparisTutari;
        }

        public void siparisleriGetir(DataGridView dataGridView)
        {
            List<SiparisModel> siparisList = new List<SiparisModel>();
  
            
            sqlConnection.Connection().Open();
            SqlCommand urungetir = new SqlCommand("select siparisID,bayiad,siparisTarih,siparisTutar from tblSiparisler INNER JOIN tblBayiler ON tblSiparisler.bayiID =tblBayiler.bayiID", sqlConnection.Connection());
            SqlDataReader data = urungetir.ExecuteReader();
            while (data.Read())
            {
                SiparisModel siparis = new SiparisModel();
                siparis.SiparisId = data[0].ToString();
                siparis.BayiId = data[1].ToString();
                siparis.SiparisTarihi = Convert.ToDateTime(data[2]);
                siparis.SiparisTutari = (float)Double.Parse(data[3].ToString());
                if(Convert.ToDouble(siparis.SiparisTutari) > 0)
                {
                    siparisList.Add(siparis);
                }
                
            }
            dataGridView.DataSource = siparisList;
            sqlConnection.Connection().Close();
        }

        public void siparisDeteylariGetir(DataGridView dataGridView, String siparisId, List<SiparisDetayModel> list)
        {

            list.Clear();
            sqlConnection.Connection().Open();
            SqlCommand siparisDetayGetir = new SqlCommand("select detayID,urunAd,urunAdet,detayFiyat from tblSiparisDetay INNER JOIN tblurunler on tblSiparisDetay.urunID=tblurunler.urunID WHERE siparisID=@p1", sqlConnection.Connection());
            siparisDetayGetir.Parameters.AddWithValue("@p1", siparisId);
            SqlDataReader data = siparisDetayGetir.ExecuteReader();
            while (data.Read())
            {
                SiparisDetayModel siparisDetay = new SiparisDetayModel();
                siparisDetay.UrunId = data[0].ToString();
                siparisDetay.urunAdı1 = data[1].ToString();
                siparisDetay.UrunAdet = data[2].ToString();
                siparisDetay.DetayFiyat = (float)Double.Parse(data[3].ToString());
                list.Add(siparisDetay);
            }
            dataGridView.DataSource = list;
            sqlConnection.Connection().Close();

        }

        public void siparistenUrunSil(String siparisDetayId)
        {
            if (siparisDetayId != "") {
                sqlConnection.Connection().Open();
                SqlCommand urunSil = new SqlCommand("DELETE tblSiparisDetay WHERE DetayID=@p1", sqlConnection.Connection());
                urunSil.Parameters.AddWithValue("@p1", siparisDetayId);
                urunSil.ExecuteNonQuery();
                sqlConnection.Connection().Close();
            }
            
        }

        public void tutarGüncelle(String id)
        {
            
            float guncelTutar = 0;
            sqlConnection.Connection().Open();
            SqlCommand guncelTutarıHesepla = new SqlCommand("select SUM(urunAdet*urunBirimFiyat) from tblSiparisDetay INNER JOIN tblurunler on tblSiparisDetay.urunID=tblurunler.urunID WHERE siparisID=@P1", sqlConnection.Connection());
            guncelTutarıHesepla.Parameters.AddWithValue("@P1", Convert.ToInt32(id));
            SqlDataReader data = guncelTutarıHesepla.ExecuteReader();
            while (data.Read())
            {
                if (data[0].ToString() != "") {
                    guncelTutar = (float)Double.Parse(data[0].ToString());
                }                
            }

            sqlConnection.Connection().Close();



            sqlConnection.Connection().Open();
            SqlCommand bayiGuncelle = new SqlCommand("UPDATE tblSiparisler SET siparisTutar=@P1 WHERE siparisID=@P2", sqlConnection.Connection());
            bayiGuncelle.Parameters.AddWithValue("@P1", guncelTutar.ToString());
            bayiGuncelle.Parameters.AddWithValue("@P2", id);
            bayiGuncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();

        }

        public SiparisDetayModel siparisDetayGetir(String detayId) {
            SiparisDetayModel siparisDetay = new SiparisDetayModel();
            sqlConnection.Connection().Open();
            SqlCommand orderDetailId = new SqlCommand("select detayID,urunAd,urunAdet,detayFiyat from tblSiparisDetay INNER JOIN tblurunler ON tblSiparisDetay.urunID=tblurunler.urunID  WHERE detayID=@p1", sqlConnection.Connection());
            orderDetailId.Parameters.AddWithValue("@p1", detayId);
            SqlDataReader data = orderDetailId.ExecuteReader();
            while (data.Read())
            {
                siparisDetay.UrunId = data[0].ToString();
                siparisDetay.urunAdı1=data[1].ToString();
                siparisDetay.UrunAdet = data[2].ToString();
                siparisDetay.DetayFiyat = (float)Double.Parse(data[3].ToString());
            }
            sqlConnection.Connection().Close();

            return siparisDetay;
        }

        public void siparisDetayGuncelle(String detayId,String adet,String siparisId) {


            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblSiparisDetay SET urunAdet = @p1, detayFiyat=(urunAdet*urunBirimFiyat) FROM tblSiparisDetay INNER JOIN tblurunler ON tblSiparisDetay.urunID = tblurunler.urunID WHERE detayID=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0",detayId);
            urunguncelle.Parameters.AddWithValue("@p1",adet);

            urunguncelle.ExecuteNonQuery();
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();


            sqlConnection.Connection().Open();
            SqlCommand siparistutar = new SqlCommand("UPDATE tblSiparisler SET siparisTutar =(select sum(detayFiyat) from tblSiparisDetay where siparisID=@p1) WHERE siparisID=@p1", sqlConnection.Connection());
            siparistutar.Parameters.AddWithValue("@p1",siparisId);

            siparistutar.ExecuteNonQuery();
            sqlConnection.Connection().Close();


        }

        public void SiparisSil(string id) {
            sqlConnection.Connection().Open();
            SqlCommand urunSil = new SqlCommand("DELETE tblSiparisler WHERE siparisID=@p1", sqlConnection.Connection());
            urunSil.Parameters.AddWithValue("@p1", id);
            urunSil.ExecuteNonQuery();
            sqlConnection.Connection().Close();
        }
       

    }
}
