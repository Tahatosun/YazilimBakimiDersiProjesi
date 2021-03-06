﻿using System;
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
        OrderProcessing orderProcessing = new OrderProcessing();
        List<SiparisDetayModel> siparisListesi = new List<SiparisDetayModel>();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            productOperation.UrunleriGetir(dataGridUrunler);
            dealerOperations.bayileriGetir(dataGridBayiler);
            orderProcessing.siparisleriGetir(dataGridSiparisler);
            changeRowColor();
            
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

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show( txtBxUrunSilID.Text+" Numaralı ürün Silinsin mi?", "Ürün Sil", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                productOperation.urunSil(txtBxUrunSilID.Text);
                productOperation.UrunleriGetir(dataGridUrunler);
            }
          

         

        }

        private void btnBayiEkle_Click(object sender, EventArgs e)
        {
            BayiEkle bayiEkle  = new BayiEkle();
            bayiEkle.bayilerDataGrid = dataGridBayiler;
            bayiEkle.Show();
        }

        private void dataGridBayiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedId = dataGridBayiler.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBayiGuncelleID.Text = selectedId;
            txtBayiSilID.Text = selectedId;
        }

        private void btnBayiGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBayiGuncelleID.Text != "")
            {
                if (dealerOperations.BayiKontrol(txtBayiGuncelleID.Text) == true) {

                    BayiGuncelle bayiGuncelle = new BayiGuncelle();
                    bayiGuncelle.bayiID = Convert.ToInt32(txtBayiGuncelleID.Text);
                    bayiGuncelle.bayilerDataGrid = dataGridBayiler;
                    bayiGuncelle.Show();

                }
                else
                {
                    MessageBox.Show("Böyle bir Bayi bulunamadı!");
                }

            }
            else {
                MessageBox.Show("Lütfen BayiID'sini Girin!");
            }


        }

        private void btnBayiSil_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(txtBxUrunSilID.Text + " Numaralı Bayi Silinsin mi?", "Bayi Sil", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dealerOperations.BayiSil(txtBayiSilID.Text);
                dealerOperations.bayileriGetir(dataGridBayiler);

            }



           
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            SiparisOlusturmaEkrani siparisOlusturmaEkrani = new SiparisOlusturmaEkrani();
            siparisOlusturmaEkrani.dataGridViewSiparisler = dataGridSiparisler;
            siparisOlusturmaEkrani.Show();

        }

       
  

        private void dataGridSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedId = dataGridSiparisler.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSiparisID.Text = selectedId;
        }

        private void btnSiparisDetayGor_Click(object sender, EventArgs e)
        {
            if (txtSiparisID.Text != "") {
                SiparisDetayiGoruntulemeEkrani siparisDetayiGoruntulemeEkrani = new SiparisDetayiGoruntulemeEkrani();
                siparisDetayiGoruntulemeEkrani.siparisId = txtSiparisID.Text;
                siparisDetayiGoruntulemeEkrani.dataGridViewsiparisler = dataGridSiparisler;
                siparisDetayiGoruntulemeEkrani.Show();
            }
            
        }
        private void changeRowColor()
        {
            foreach(DataGridViewRow row in dataGridUrunler.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) < 10)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(row.Cells[2].Value) < 20)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;

                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            productOperation.UrunleriGetir(dataGridUrunler);
     
            dealerOperations.bayileriGetir(dataGridBayiler);

            orderProcessing.siparisleriGetir(dataGridSiparisler);
            changeRowColor();
            
        }
    }
}
