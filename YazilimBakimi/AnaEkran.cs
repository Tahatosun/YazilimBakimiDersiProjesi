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
        DealerOperations dealerOperations = new DealerOperations();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            productOperation.UrunleriGetir(dataGridUrunler);
            dealerOperations.bayileriGetir(dataGridBayiler);
            
            //dataGridUrunler.DataSource = productOperation.UrunleriGetir();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.urunlerDataGrid = dataGridUrunler;
            urunEkle.Show();                        

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {

            if (txtBxUrunGuncelleID.Text != "") {

                if (productOperation.UrunKontrol(txtBxUrunGuncelleID.Text) == true)
                {
                    UrunGuncelle urunGuncelle = new UrunGuncelle();
                    urunGuncelle.urunID = Convert.ToInt32(txtBxUrunGuncelleID.Text);
                    urunGuncelle.urunelerDataGrid = dataGridUrunler;
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

        private void dataGridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedId = dataGridUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBxUrunGuncelleID.Text = selectedId;
            txtBxUrunSilID.Text = selectedId;

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

            productOperation.urunSil(txtBxUrunSilID.Text);
            productOperation.UrunleriGetir(dataGridUrunler);

        }

        private void btnBayiEkle_Click(object sender, EventArgs e)
        {
            BayiEkle bayiEkle  = new BayiEkle();
            bayiEkle.bayilerDataGrid = dataGridBayiler;
            bayiEkle.Show();
        }
    }
}
