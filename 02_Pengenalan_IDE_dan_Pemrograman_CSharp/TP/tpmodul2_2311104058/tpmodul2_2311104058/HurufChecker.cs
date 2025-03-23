using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul2_2311104058
{
    class HurufChecker
    {
        public void CekHuruf()
        {
            Console.Write("Masukkan satu huruf: ");
            char huruf = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(huruf) && char.IsUpper(huruf))
            {
                if ("AIUEO".Contains(huruf))
                {
                    Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
                }
                else
                {
                    Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Harap masukkan satu huruf kapital.");
            }
        }
    }
}
