using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Ornek2
{
    public struct Personel
    {

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }
        public bool Cinsiyet { get; set; }

        public Personel(int yas)
        {
            AdSoyad = Adres = "";
            Cinsiyet = false;
            Yas = yas;
        }

        public string PersonelBilgileriniGoster()
        {
            return string.Format("{0} - {1}  ({2}) - {3} ", AdSoyad, Yas, (Cinsiyet ? "erkek" : "Kadın"), Adres);
        }

    }
}
