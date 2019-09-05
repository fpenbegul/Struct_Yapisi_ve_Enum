using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_OrnekForm
{
    public struct Ogrenciler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }

        public override string ToString()
        {
            return string.Format(Ad + " " + Soyad + " - " + (Cinsiyet ? "Erkek" : "Kadın") + " - " + TCNo + " - " + DogumTarihi.ToString("dd.MMMM.yy"));
        }


    }
}
