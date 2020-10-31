using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi
{
    class Urun
    {
        String urunID;
        String urunAdi;
        String Stok;
        String birimFiyat;

        public string UrunID { get => urunID; set => urunID = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public string urunStok { get => Stok; set => Stok = value; }
        public string urunBirimFiyat { get => birimFiyat; set => birimFiyat = value; }
    }
}
