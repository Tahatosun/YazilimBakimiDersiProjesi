using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YazilimBakimi
{
    public partial class GirisEkrani : MetroFramework.Forms.MetroForm
    {
        LoginDataBaseOperations logindataBaseOperations = new LoginDataBaseOperations();
      
        public GirisEkrani()
        {
            InitializeComponent();
        }


        private void btnKayitol_Click(object sender, EventArgs e)
        {
            pnlKayitol.Visible = true;
            pnlLogin.Visible = false;
        }

        
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            pnlKayitol.Visible = false;
            pnlLogin.Visible = true;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            

            if (txtBoxAdKayit.Text != "" && txtBoxSoyadKayit.Text != "" && txtBoxEpostaKayit.Text != "" && txtBoxSifreKayit.Text != "" && txtBoxSifreKayitTekrar.Text != "") {
                if (txtBoxSifreKayit.Text.Length >= 8)
                {
                    Boolean sayi = false;
                    Boolean kucukHarf = false;
                    Boolean buyukHarf = false;
                    Boolean ozelKarakter = false;
                    foreach (char x in txtBoxSifreKayit.Text)
                    {
                        if (Convert.ToInt32(x) >= 48 && Convert.ToInt32(x) <= 57)
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
                    if (sayi = true && kucukHarf == true && buyukHarf == true && ozelKarakter == true && txtBoxSifreKayit.Text == txtBoxSifreKayitTekrar.Text)
                    {


                        if (logindataBaseOperations.EpostaKontrol(txtBoxEpostaKayit.Text) == true)
                        {
                            logindataBaseOperations.KullaniciEkle(txtBoxAdKayit.Text, txtBoxSoyadKayit.Text, txtBoxEpostaKayit.Text, txtBoxSifreKayit.Text);
                        }
                        else
                        {
                            MessageBox.Show("Bu e-posta adresiyle bir Kayıt Mevcut");
                        }

                        pnlKayitol.Visible = false;
                        pnlLogin.Visible = true;



                    }
                    else
                    {
                        MessageBox.Show("şifre en az birer adet\n rakam, büyük harf, küçük harf, özel karkakter\niçermelidir.");
                    }


                }
                else
                {
                    MessageBox.Show("Şifreniz Mininum 8 Karakter Olmalıdır.");
                }

            

              
            }
            else
            {
                MessageBox.Show("Bütün alanların dolu olduğundan Emin olun!!");
            }

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            if (logindataBaseOperations.Giris(txtBoxKullaniciEposta.Text, txtBoxSifre.Text)==true){
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici Adi ve Şifrenizi Kontrol Edin!");
            }
           
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }
    }
}
