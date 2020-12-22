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
    public partial class UrunGuncelle : MetroFramework.Forms.MetroForm
    {
        ProductOperations productOperations = new ProductOperations();
        public int urunID;
        public DataGridView urunelerDataGrid;
        UrunModel urun = new UrunModel();
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            urun=productOperations.urunGetir(urunID.ToString());
            txtUrunGuncelleUrunID.Text = urun.UrunID;
            txtBxUrunAdiGuncelle.Text = urun.UrunAdi;
            txtBxStokAdediGuncelle.Text = urun.urunStok;
            txtBxBirimFiyatGuncelle.Text = urun.urunBirimFiyat.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBxUrunAdiGuncelle.Text != "" && txtBxStokAdediGuncelle.Text != "" && txtBxBirimFiyatGuncelle.Text != "")
            {
                if (Convert.ToDouble(txtBxStokAdediGuncelle.Text) >= 0 && Convert.ToDouble(txtBxBirimFiyatGuncelle.Text) > 0)
                {
                    productOperations.urunGuncelle(txtUrunGuncelleUrunID.Text,txtBxUrunAdiGuncelle.Text,txtBxStokAdediGuncelle.Text,txtBxBirimFiyatGuncelle.Text);
                    productOperations.UrunleriGetir(urunelerDataGrid);
                }
                else
                {
                    MessageBox.Show("Lütfen alanların Doğruluğundan emin olun!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun!");
            }
        }
    }
}
