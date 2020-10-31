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
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {
        ProductOperations productOperation = new ProductOperations();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {

            if (txtBxUrunGuncelleID.Text != "") {

                if (productOperation.UrunKontrol(txtBxUrunGuncelleID.Text) == true)
                {
                    UrunGuncelle urunGuncelle = new UrunGuncelle();
                    urunGuncelle.urunID = Convert.ToInt32(txtBxUrunGuncelleID.Text);
                    urunGuncelle.Show();
                }
                else {
                    MessageBox.Show("Böyle bir ürün bulunamadı!");
                }

            }
            else
            {
                MessageBox.Show("Lütfen ÜrünID'sini Girin!");
            }

        }
    }
}
