using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2_2311104058
{
    class ArrayProcessor
    {
        private int[] arr = new int[50];

        public ArrayProcessor()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine($"{i} #$#$");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} ##");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} $$");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
