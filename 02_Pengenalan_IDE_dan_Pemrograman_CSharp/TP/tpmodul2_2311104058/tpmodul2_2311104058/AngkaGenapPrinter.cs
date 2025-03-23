using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul2_2311104058
{
    class AngkaGenapPrinter
    {
        public void CetakAngkaGenap()
        {
            int[] angkaGenap = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < angkaGenap.Length; i++)
            {
                Console.WriteLine($"Angka genap {i + 1} : {angkaGenap[i]}");
            }
        }
    }
}
