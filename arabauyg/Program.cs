using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabauyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            depo arac = new depo("Demirel Oto Galeri");
            arac.sevaraba();

            Console.WriteLine("elimizde = " + arac.arabamarkaGetir() + " adet arac var");

            string secenek = "e";
            while (secenek == "e")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
                Console.WriteLine("1) Bütün arabaları listele");
                Console.WriteLine("2) Aradığınız aracın Markasını giriniz");
                secenek = Console.ReadLine();
                Console.Clear();
                if (secenek == "1")
                {
                    for (int i = 0; i < arac.arabamarkaGetir(); i++)
                    {
                        araba a = arac.arabaGetir(i);
                        Console.WriteLine();
                        Console.WriteLine($"{i + 1}) {a.Marka} {a.model} {a.yıl} {a.renk} {a.fiyat} ");
                       


                    }
                }
            }
        }
    }
}
