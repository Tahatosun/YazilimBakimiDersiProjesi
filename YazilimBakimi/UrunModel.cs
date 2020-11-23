using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi
{
    class UrunModel
    {
        String urunID;
        String urunAdi;
        String Stok;
        float birimFiyat;

        public string UrunID { get => urunID; set => urunID = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public string urunStok { get => Stok; set => Stok = value; }
        public float urunBirimFiyat { get => birimFiyat; set => birimFiyat = value; }
    }
}
