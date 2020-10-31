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
        LoginDataBaseOperations LogindataBaseOperations = new LoginDataBaseOperations();
      
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
                if (txtBoxSifreKayit.Text == txtBoxSifreKayitTekrar.Text)
                {
                    if (LogindataBaseOperations.EpostaKontrol(txtBoxEpostaKayit.Text) == true) {
                        LogindataBaseOperations.KullaniciEkle(txtBoxAdKayit.Text, txtBoxSoyadKayit.Text, txtBoxEpostaKayit.Text, txtBoxSifreKayit.Text);
                    }
                    else
                    {
                        MessageBox.Show("Bu e-posta adresiyle bir Kayıt Mevcut");
                    }

                    pnlKayitol.Visible = false;
                    pnlLogin.Visible = true;

                }
                else {
                    MessageBox.Show("Şifrelerin Doğruluğunu Kontrol Edin!");
                    txtBoxSifreKayit.Text = "";
                    txtBoxSifreKayitTekrar.Text = "";                    
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

            if (LogindataBaseOperations.Giris(txtBoxKullaniciEposta.Text, txtBoxSifre.Text)==true){
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici Adi ve Şifrenizi Kontrol Edin!");
            }
           
        }
    }
}
