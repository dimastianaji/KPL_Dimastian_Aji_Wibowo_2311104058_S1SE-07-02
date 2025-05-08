using System;
using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Matematika math = new Matematika();

        Console.WriteLine("FPB(60, 45): " + math.FPB(60, 45));
        Console.WriteLine("KPK(12, 8): " + math.KPK(12, 8));
        Console.WriteLine("Turunan({1, 4, -12, 9}): " + math.Turunan(new int[] { 1, 4, -12, 9 }));
        Console.WriteLine("Integral({4, 6, -12, 9}): " + math.Integral(new int[] { 4, 6, -12, 9 }));
    }
}
