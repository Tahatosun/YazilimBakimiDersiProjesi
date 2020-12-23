using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi
{
    public partial class SifremiUnuttum : MetroFramework.Forms.MetroForm
    {
        string dogrulamaKodu;
        String kulEpsota;
        int sayac=0;

        LoginDataBaseOperations loginDataBaseOperations = new LoginDataBaseOperations();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            /*
            * Şifre yenileme maili gönderen kod bloğu
            */
            var rand = new Random();
            kulEpsota = txtSUKullaniciEposta.Text;
            dogrulamaKodu = rand.Next(100000, 999999).ToString();
            if (loginDataBaseOperations.DogrulamaKoduGonder(kulEpsota, dogrulamaKodu)) {
                pnlSUEpostaGonder.Visible = false;
                pnlSUKodOnay.Visible = true;
            }
            else{
                MessageBox.Show("Eposta Adresini Kontol Edin!");
            }
                       
            
        }

        private void btnSUGeriDon_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {

            if (txtSUSifre.Text.Length >= 8)
            {
                Boolean sayi = false;
                Boolean kucukHarf = false;
                Boolean buyukHarf = false;
                Boolean ozelKarakter = false;
                foreach (char x in txtSUSifre.Text)
                {
                    if(Convert.ToInt32(x)>=48 && Convert.ToInt32(x) <= 57)
                    {
                        sayi = true;
                    }
                    if (Convert.ToInt32(x) >= 97 && Convert.ToInt32(x) <= 122)
                    {
                        kucukHarf = true;
                    }
                    if (Convert.ToInt32(x) >= 65 && Convert.ToInt32(x) <= 90)
                    {
                        buyukHarf = true;
                    }
                    if (Convert.ToInt32(x) >= 33 && Convert.ToInt32(x) <= 64 || Convert.ToInt32(x) >= 91 && Convert.ToInt32(x) <= 96 || Convert.ToInt32(x) >= 123 && Convert.ToInt32(x) <= 126)
                    {
                        ozelKarakter = true;
                    }
                }
                if (sayi = true && kucukHarf == true && buyukHarf == true && ozelKarakter == true && txtSUSifre.Text == txtSUSifreTekrar.Text)
                {
                    loginDataBaseOperations.sifreSifirla(txtSUSifre.Text,kulEpsota);
                    GirisEkrani girisEkrani = new GirisEkrani();
                    girisEkrani.Show();
                    this.Hide(); 
                }
                else {
                    MessageBox.Show("şifre en az birer adet\n rakam, büyük harf, küçük harf, özel karkakter\niçermelidir.");
                }


            }
            else {
                MessageBox.Show("Şifreniz Mininum 8 Karakter Olmalıdır.");
            }





        }

        private void btnSUOnayla_Click(object sender, EventArgs e)
        {
            if (txtSUKod.Text == dogrulamaKodu) {
                pnlSUSifreyiDegistir.Visible = true;
                pnlSUKodOnay.Visible = false;
            }
            else{
                sayac++;
                if (sayac >= 3) {
                    MessageBox.Show("Çok fazla Yanlış Giriş Yaptınız.\n admin@yazilimbakim.com \n adresiyle iletişime geçin.");
                    loginDataBaseOperations.KullanıcıDurumuPasif(kulEpsota);
                    GirisEkrani girisEkrani = new GirisEkrani();
                    girisEkrani.Show();
                    this.Hide();
                }
            }

            
            
        }
    }
}
