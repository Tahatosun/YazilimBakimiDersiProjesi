using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi
{
    class SiparisDetayModel
    {        
        String urunId;
        String urunAdi;
        String urunAdet;
        float detayFiyat;

        public string UrunId { get => urunId; set => urunId = value; }
        public string urunAdi1 { get => urunAdi; set => urunAdi = value; }
        public string UrunAdet { get => urunAdet; set => urunAdet = value; }
        public float DetayFiyat { get => detayFiyat; set => detayFiyat = value; }

    }
}
