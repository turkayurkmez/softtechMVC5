using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverViewCSharp
{
    public static class Filtreleyici
    {

        public static int[] filtrele(int[] array, Func<int, bool> metot)
        {
            List<int> sonuc = new List<int>();
            foreach (var item in array)
            {
                if (metot(item))
                {
                    sonuc.Add(item);
                }
            }
            return sonuc.ToArray();
        }
    }
}
