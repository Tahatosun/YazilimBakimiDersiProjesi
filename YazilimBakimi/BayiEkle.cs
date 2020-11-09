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
    public partial class BayiEkle : MetroFramework.Forms.MetroForm
    {
        public DataGridView bayilerDataGrid;
        DealerOperations dealerOperations = new DealerOperations();

        public BayiEkle()
        {
            InitializeComponent();
        }

  
        private void BayiEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkleBayi_Click(object sender, EventArgs e)
        {

            if (txtBayiAd.Text != "" && txtBayiAdres.Text != "" && txtBayiEposta.Text != "" && txtBayiTel.Text != "" && txtBayiTel.Text.Length==11) {

                dealerOperations.bayiEkle(txtBayiAd.Text, txtBayiEposta.Text, txtBayiTel.Text, txtBayiAdres.Text);

                txtBayiAd.Text = "";
                txtBayiAdres.Text = "";
                txtBayiEposta.Text = "";
                txtBayiTel.Text = "";
                dealerOperations.bayileriGetir(bayilerDataGrid);

            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları kontrol Edin!");
            }


        }
    }
}
