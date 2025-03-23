using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2_2311104058
{
    class PrimeChecker
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public void CheckPrime()
        {
            Console.Write("Masukkan angka (1-10000): ");
            int nilaiInt = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(nilaiInt))
            {
                Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
            }
            else
            {
                Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
            }
        }
    }
}
