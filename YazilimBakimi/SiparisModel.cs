using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi
{
    class SiparisModel
    {
        String siparisId;
        String bayiId;
        DateTime siparisTarihi;
        float siparisTutari;

        public string SiparisId { get => siparisId; set => siparisId = value; }
        public string BayiId { get => bayiId; set => bayiId = value; }
        public DateTime SiparisTarihi { get => siparisTarihi; set => siparisTarihi = value; }
        public float SiparisTutari { get => siparisTutari; set => siparisTutari = value; }
    }
}
