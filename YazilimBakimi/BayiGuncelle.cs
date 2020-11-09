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
    public partial class BayiGuncelle : MetroFramework.Forms.MetroForm
    {
        DealerOperations dealerOperations = new DealerOperations();
        public int bayiID;
        public DataGridView bayilerDataGrid;
        Bayi bayi = new Bayi();



        public BayiGuncelle()
        {
            InitializeComponent();
        }

        private void BayiGuncelle_Load(object sender, EventArgs e)
        {
            bayi = dealerOperations.BayiGetir(bayiID.ToString());
            txtBayiIDGuncelle.Text = bayi.BayiId;
            txtBayiAdGuncelle.Text = bayi.BayiAd;
            txtBayiAdresGuncelle.Text = bayi.BayiAdres;
            txtBayiEpostaGuncelle.Text = bayi.BayiEposta;
            txtBayiTelGuncelle.Text = bayi.BayiTel;

        }

        private void btnGuncelleBayi_Click(object sender, EventArgs e)
        {


            if (txtBayiAdGuncelle.Text != "" && txtBayiAdresGuncelle.Text != "" && txtBayiEpostaGuncelle.Text != "" && txtBayiTelGuncelle.Text!="")
            {
                dealerOperations.BayiGuncelle(txtBayiIDGuncelle.Text, txtBayiAdGuncelle.Text, txtBayiEpostaGuncelle.Text, txtBayiAdresGuncelle.Text, txtBayiTelGuncelle.Text);
                dealerOperations.bayileriGetir(bayilerDataGrid);
               
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun!");
            }


        }
    }
}
