using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12_2311104058
{
    public static class PangkatHelper
    {
        public static int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            if (b > 10 || a > 100)
                return -2;

            try
            {
                int hasil = 1;
                checked
                {
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                }
                return hasil;
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
    }
}
