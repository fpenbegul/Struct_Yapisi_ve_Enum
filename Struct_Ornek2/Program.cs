using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel()
            {
                Adres = "Ankara",
                AdSoyad = "Ali veli",
                Cinsiyet = true,
                Yas = 11
            };
            Console.WriteLine(p1.PersonelBilgileriniGoster());
            Console.WriteLine("--------------------------------");
            Personel p2 = new Personel(17)
            {
                Adres = "İzmir",
                AdSoyad = "Ayşe Fatma",
            };
            Console.WriteLine(p2.PersonelBilgileriniGoster());
            Console.ReadLine();
        }
    }
}
