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
    public partial class SiparisOlusturmaEkrani : MetroFramework.Forms.MetroForm
    {
        public SiparisOlusturmaEkrani()
        {
            InitializeComponent();
        }

        UrunModel seciliUrun = new UrunModel();
        List<SiparisDetayModel> siparisListesi =new List<SiparisDetayModel>();
        List<UrunModel> urunListesi = new List<UrunModel>();
        List<Bayi> bayiList = new List<Bayi>();
        OrderProcessing orderProcessing = new OrderProcessing();
        public DataGridView dataGridViewSiparisler = new DataGridView();

       

        private void SiparisOlusturmaEkrani_Load(object sender, EventArgs e)
        {           
            orderProcessing.UrunlerComboboxItemsAdd(cmbBxUrunler, urunListesi);
            orderProcessing.cmbBxSiparisiVerenBayiItemsAdd(cmbBxSiparisiVerenBayi, bayiList);
        }

        private void cmbBxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {      
            seciliUrun = urunListesi[cmbBxUrunler.SelectedIndex];
            numUrunAdeti.Maximum = Convert.ToInt32(seciliUrun.urunStok);
            txtFiyat.Text = (Convert.ToInt32(seciliUrun.urunBirimFiyat) * Convert.ToInt32(numUrunAdeti.Value)).ToString();
            if (Convert.ToInt32(seciliUrun.urunStok) > 0)
            {
                numUrunAdeti.Value = 1;
            }
            else {
                numUrunAdeti.Value = 0; 
            }
            lblMevcutStok.Text = seciliUrun.urunStok;
        }

        private void numUrunAdeti_ValueChanged(object sender, EventArgs e)
        {           
            txtFiyat.Text = (Convert.ToInt32(seciliUrun.urunBirimFiyat) * Convert.ToInt32(numUrunAdeti.Value)).ToString();

            
        }

        private void btnUrunuSipariseEkle_Click(object sender, EventArgs e)
        {
            if (numUrunAdeti.Value > 0)
            {
                orderProcessing.SipariseUrunEkle(urunListesi, siparisListesi, cmbBxUrunler.Text, seciliUrun.UrunID,
                                                    numUrunAdeti.Value.ToString(), urunListesi[cmbBxUrunler.SelectedIndex].urunBirimFiyat);
                txtToplamFiyat.Text = orderProcessing.siparisTutarıHesapla(siparisListesi).ToString();              
            }
            orderProcessing.dataGridSipariseAitUrunleriGetir(dataGridSipariseAitUrunler, siparisListesi);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            if (cmbBxSiparisiVerenBayi.Text != "")
            {
                orderProcessing.SiparisOlustur(bayiList[cmbBxSiparisiVerenBayi.SelectedIndex].BayiId, orderProcessing.siparisTutarıHesapla(siparisListesi), siparisListesi);
                orderProcessing.siparisleriGetir(dataGridViewSiparisler);
                this.Close();
            }


        }
    }
}
