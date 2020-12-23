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
            pnlSUEpostaGonder.Visible = false;
            pnlSUKodOnay.Visible = true;
        }

        private void btnSUGeriDon_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {
            /*
             * Kullanıcıya ait şifreyi değiştiren kod bloğu
             */
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void btnSUOnayla_Click(object sender, EventArgs e)
        {
            /*
             * Eposta gönderilen kod ile girilen kodun doğruluğunu kontrol eden kod bloğu
             */

            pnlSUSifreyiDegistir.Visible = true;
            pnlSUKodOnay.Visible = false;
            
        }
    }
}
