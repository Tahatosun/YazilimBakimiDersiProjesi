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
              
    public partial class UrunEkle : MetroFramework.Forms.MetroForm
    {
        public DataGridView urunlerDataGrid;
        ProductOperations productOperations = new ProductOperations();
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBxBirimFiyat.Text != "" && txtBxStokAdedi.Text != "" && txtBxUrunAdi.Text != "")
            {
                if (Convert.ToInt64(txtBxStokAdedi.Text) >= 0 && Double.Parse(txtBxBirimFiyat.Text) > 0)
                {
                    productOperations.UrunEkle(txtBxUrunAdi.Text, Convert.ToInt64(txtBxStokAdedi.Text), Double.Parse(txtBxBirimFiyat.Text));
                    txtBxBirimFiyat.Text = "";
                    txtBxStokAdedi.Text = "";
                    txtBxUrunAdi.Text = "";
                    productOperations.UrunleriGetir(urunlerDataGrid);
                }
                else {
                    MessageBox.Show("Lütfen alanların Doğruluğundan emin olun!");
                }
            }
            else {
                MessageBox.Show("Lütfen gerekli alanları doldurun!");
            }



        }
    }
}
