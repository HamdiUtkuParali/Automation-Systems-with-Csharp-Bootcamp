using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzinlik
{
    internal class Urun
    {
        public string UrunAdı;
        public int Fiyat;
        public int Adet;

        public Urun(string urunAd, int fiyat, int adet)
        {
            UrunAdı = urunAd;
            Fiyat = fiyat;
            Adet = adet;
        }

    }
}
