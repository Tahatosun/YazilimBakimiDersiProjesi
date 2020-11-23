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
    public partial class SiparisDetayGuncelle : MetroFramework.Forms.MetroForm
    {
        public SiparisDetayGuncelle()
        {
            InitializeComponent();
        }

        public String detayId;
        OrderProcessing orderProcessing = new OrderProcessing();
        public DataGridView dataGridViewsiparisler = new DataGridView();
        public DataGridView dataGridSiparisDetay = new DataGridView();
        public String siparisId;
        List<SiparisDetayModel> siparisDetayList = new List<SiparisDetayModel>();
        
        private void SiparisDetayGuncelle_Load(object sender, EventArgs e)
        {
            SiparisDetayModel guncellenen = new SiparisDetayModel();
            guncellenen = orderProcessing.siparisDetayGetir(detayId);

            txtSiparisGuncelleUrunID.Text = guncellenen.UrunId;
            txtSiparisUrunAdiGuncelle.Text = guncellenen.urunAdı1;
            txtSiparisUrunAdediGuncelle.Text = guncellenen.UrunAdet;
            txtToplamFiyatGuncelle.Text = guncellenen.DetayFiyat.ToString();

        }

        private void btnSiparisUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSiparisUrunAdediGuncelle.Text != null) {
                orderProcessing.siparisDetayGuncelle(detayId, txtSiparisUrunAdediGuncelle.Text, siparisId);
                orderProcessing.siparisDeteylariGetir(dataGridSiparisDetay, siparisId, siparisDetayList);
                orderProcessing.siparisleriGetir(dataGridViewsiparisler);
                this.Close();
            }
            
        }
    }
}
