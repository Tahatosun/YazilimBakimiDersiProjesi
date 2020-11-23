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
    public partial class SiparisDetayiGoruntulemeEkrani : MetroFramework.Forms.MetroForm
    {
        public String siparisId;
        OrderProcessing orderProcessing = new OrderProcessing();
        List<SiparisDetayModel> siparisDetayList = new List<SiparisDetayModel>();


        public SiparisDetayiGoruntulemeEkrani()
        {
            InitializeComponent();
        }

        private void SiparisDetayiGoruntulemeEkrani_Load(object sender, EventArgs e)
        {
            orderProcessing.siparisDeteylariGetir(dataGridSiparisDetayUrunler, siparisId, siparisDetayList);
        }

        private void dataGridSiparisDetayUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String detayId = dataGridSiparisDetayUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSiparistenSilinecekUrunID.Text = detayId;
        }

        private void btnSiparistenUrunuSil_Click(object sender, EventArgs e)
        {
            orderProcessing.siparistenUrunSil(txtSiparistenSilinecekUrunID.Text);
            orderProcessing.tutarGüncelle(siparisId);
            dataGridSiparisDetayUrunler.DataSource = null;
            orderProcessing.siparisDeteylariGetir(dataGridSiparisDetayUrunler, siparisId,siparisDetayList);
            
        }

        private void btnSiparisiGuncelle_Click(object sender, EventArgs e)
        {
            List<SiparisDetayModel> list = new List<SiparisDetayModel>();
            
            





        }
    }
}