using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabauyg
{
    internal class depo
    {

        araba[] arabalar;

        public string GaleriAdi { get; set; }

        public depo(string galeriAdi)
        {
            arabalar = new araba[0];
            GaleriAdi = galeriAdi;  
        }

        public void ekle(araba Araba)
        {
            araba[] temp = new araba[arabalar.Length +1];
            Array.Copy(arabalar, temp, arabalar.Length);
            temp[temp.Length - 1] = Araba;
            arabalar = temp;
        }

        public void sevaraba()
        {
            ekle(new araba() { Marka = "Mercedes", model = "Amg Gt", yıl = "2015", renk = "sarı", fiyat = "13.900.000" });
            ekle(new araba() { Marka = "Mercedes", model = "G63 Amg", yıl = "2023", renk = "siyah", fiyat = "24.750.000" });
            ekle(new araba() { Marka = "Audi", model = "Rs5", yıl = "2011", renk = "siyah", fiyat = "3.525.900" });
            ekle(new araba() { Marka = "Audi", model = "RsQ8", yıl = "2020", renk = "siyah", fiyat = "13.200.000" });
            ekle(new araba() { Marka = "Bmw", model = "M5", yıl = "2021", renk = "Gri", fiyat = "12.900.000" });
            ekle(new araba() { Marka = "Bmw", model = "M3", yıl = "2014", renk = "Gri", fiyat = "2.450.000" });
            ekle(new araba() { Marka = "Nissan", model = "Gt-R35", yıl = "2013", renk = "Beyaz", fiyat = "23.000.000" });
            ekle(new araba() { Marka = "Nissan", model = "S14", yıl = "1995", renk = "Mor", fiyat = "2.350.000" });

        }
       public int arabamarkaGetir()
        {
            return arabalar.Length;
        }

        public araba arabaGetir(int index)
        {
            return arabalar[index];
        }

        public void arabamarka()
        {
            Console.WriteLine("Hangi marka araç aradınız");
            string secenek = Console.ReadLine();
            Console.Clear();
            int a = 0;
            Console.WriteLine("*-*-*-" + secenek + "Marka araç istiyorum");
            for (int i = 0; i < arabalar.Length; i++)
            {
                if (secenek == arabalar[i].Marka)
                {
                    a++;
                    Console.WriteLine("araç elinizde var mı?");
                    if (arabalar[i].Marka  == "e")
                    {
                        Console.WriteLine("aktif\n");
                    }
                    else { Console.WriteLine("pasif\n"); }

                }
            }
        }


    }
}
