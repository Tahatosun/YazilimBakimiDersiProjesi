using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi
{
    class LoginDataBaseOperations
    {

        SQlConnection sqlConnection = new SQlConnection();


        public void KullaniciEkle(String ad, String soyad, String eposta, String sifre) {
            sqlConnection.Connection().Open();

            PasswordEncryption passwordEncryption = new PasswordEncryption();


            SqlCommand userAdd = new SqlCommand("insert into tblKullanici (KulAd,KulSoyad,kulEposta,kulSifre) values(@p1,@p2,@p3,@p4)", sqlConnection.Connection());
            userAdd.Parameters.AddWithValue("@p1", ad);
            userAdd.Parameters.AddWithValue("@p2", soyad);
            userAdd.Parameters.AddWithValue("@p3", eposta);
            userAdd.Parameters.AddWithValue("@p4", passwordEncryption.Md5(sifre));
            userAdd.ExecuteNonQuery();
            sqlConnection.Connection().Close();

            SendMail sendMail = new SendMail();
            String mesaj = "<h1>Yazılım Bakımı CRM Hesabınız Oluşturuldu.</h1> <p>Kullanıcı Epostanız: " + eposta + "</p><p>  Şifreniz: " + sifre + "</p><p>Parolanızı güvenliğiniz için hiç kimseyle Paylaşmayın!</p>";
            sendMail.Send(eposta, mesaj, "aramıza Hoş geldin");
        }

        public Boolean EpostaKontrol(String eposta) {

            sqlConnection.Connection().Open();
            SqlCommand epostaKontrol = new SqlCommand("select kulEposta from tblKullanici", sqlConnection.Connection());
            SqlDataReader data = epostaKontrol.ExecuteReader();
            while (data.Read()) {
                if (eposta == data[0].ToString()) {
                    sqlConnection.Connection().Close();
                    return false;
                }
            }
            sqlConnection.Connection().Close();
            return true;
        }

        public Boolean Giris(string eposta, string sifre)
        {
            PasswordEncryption passwordEncryption = new PasswordEncryption();


            sqlConnection.Connection().Open();
            SqlCommand epostaKontrol = new SqlCommand("select kulEposta, kulSifre from tblKullanici", sqlConnection.Connection());
            SqlDataReader data = epostaKontrol.ExecuteReader();
            while (data.Read())
            {
                if (eposta == data[0].ToString() && passwordEncryption.Md5(sifre) == data[1].ToString())
                {
                    sqlConnection.Connection().Close();
                    return true;
                }
            }
            sqlConnection.Connection().Close();
            return false;
        }


        public Boolean DogrulamaKoduGonder(string eposta , string kod) {

            if (!EpostaKontrol(eposta))
            {
                SendMail sendMail = new SendMail();
                String mesaj = "<h1>Yazılım Bakımı CRM Doğrulama Kodu.</h1> <p>Kullanıcı Epostanız: " + eposta + "</p><p>  Doğrulama Kodunuz: " + kod + "</p><p>Doğrulama Kodunu güvenliğiniz için hiç kimseyle Paylaşmayın!</p>";
                sendMail.Send(eposta, mesaj, "Doğrulama Kodu");
                return true;
            }
            else {
               return false;
            }

        
        }

        public void KullanıcıDurumuPasif(string eposta) {
            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblKullanici SET KulDurum=0  WHERE kulEposta=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0", eposta);
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();
        }


        public void sifreSifirla(string sifre,string eposta) {           
            PasswordEncryption passwordEncryption = new PasswordEncryption();
            MessageBox.Show(passwordEncryption.Md5(sifre) + "--" + eposta);
            sqlConnection.Connection().Open();
            SqlCommand urunguncelle = new SqlCommand("UPDATE tblKullanici SET kulSifre=@p1  WHERE kulEposta=@p0", sqlConnection.Connection());
            urunguncelle.Parameters.AddWithValue("@p0", eposta);
            urunguncelle.Parameters.AddWithValue("@p1", passwordEncryption.Md5(sifre));
            urunguncelle.ExecuteNonQuery();
            sqlConnection.Connection().Close();
        }

    }
}
