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
        List<il> iller = new List<il>();
        List<ilce> ilceler = new List<ilce>();

        public BayiEkle()
        {
            InitializeComponent();
        }

  
        private void BayiEkle_Load(object sender, EventArgs e)
        {
            dealerOperations.cmbBayiEkleIlItemsAdd(cmbBayiEkleil, iller);
        }

        private void btnEkleBayi_Click(object sender, EventArgs e)
        {

            if (txtBayiAd.Text != "" && txtBayiAdres.Text != "" && txtBayiEposta.Text != "" && txtBayiTel.Text != "" && txtBayiTel.Text.Length==11 && cmbBayiEkleil.Text!="" && cmbBxilce.Text!="") {

                if (dealerOperations.EpostaKontrolBayi(txtBayiEposta.Text))
                {
                    dealerOperations.bayiEkle(txtBayiAd.Text, txtBayiEposta.Text, txtBayiTel.Text, txtBayiAdres.Text + " " + cmbBayiEkleil.Text + "/" + cmbBxilce.Text);

                    txtBayiAd.Text = "";
                    txtBayiAdres.Text = "";
                    txtBayiEposta.Text = "";
                    txtBayiTel.Text = "";
                    dealerOperations.bayileriGetir(bayilerDataGrid);
                    this.Close();
                }
                else {
                    MessageBox.Show("eposta adresini kontrol edin");
                }

                

            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları kontrol Edin!");
            }


        }

        private void cmbBayiEkleil_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbBxilce.Items.Clear();           
            dealerOperations.cmbBayiEkleIlceItemsAdd(cmbBxilce, ilceler, (cmbBayiEkleil.SelectedIndex + 1).ToString());           
        }
    }
}
