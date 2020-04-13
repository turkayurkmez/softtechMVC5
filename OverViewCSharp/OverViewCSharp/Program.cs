using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverViewCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            //2001
            var filtre1 = Filtreleyici.filtrele(sayilar, ciftSayilar);
            //  goster(filtre1);
            //2005
            var filtre2 = Filtreleyici.filtrele(sayilar, delegate (int s) { return s % 3 == 0; });
            //2008
            var filtre3 = Filtreleyici.filtrele(sayilar, x => x % 5 == 0);
            //2012
            filtre3.ToList().ForEach(x => Console.WriteLine(x));

            //goster(filtre3);
            Console.ReadLine();
        }

        private static void goster(int[] filtre)
        {
            foreach (var item in filtre)
            {
                Console.WriteLine(item);
            }
        }

        static int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //static int[] filtrele(int[] array)
        //{
        //    List<int> sonuc = new List<int>();
        //    foreach (var item in array)
        //    {
        //        if (ucunKatlari(item))
        //        {
        //            sonuc.Add(item);
        //        }
        //    }
        //    return sonuc.ToArray();
        //}

        static bool ciftSayilar(int deger)
        {
            return deger % 2 == 0;
        }


    }
}
