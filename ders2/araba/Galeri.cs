using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba
{
    class Galeri
    {
        private List<Araba> arabalar;

        public Galeri()
        {
            arabalar=new List<Araba>();
        }

        public void ArabaEkle(string marka,short model,string renk)
        {
            arabalar.Add(new Araba{Marka = marka,Model = model,Renk = renk});
        }
        public void ArabaSat(Araba a)
        {
            arabalar.Remove(a);
        }

        public List<Araba> ArabaListele()
        {
            return arabalar;
        }
    }
}
