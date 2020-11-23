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
        String urunAdı;
        String urunAdet;
        float detayFiyat;

        public string UrunId { get => urunId; set => urunId = value; }
        public string urunAdı1 { get => urunAdı; set => urunAdı = value; }
        public string UrunAdet { get => urunAdet; set => urunAdet = value; }
        public float DetayFiyat { get => detayFiyat; set => detayFiyat = value; }

    }
}
