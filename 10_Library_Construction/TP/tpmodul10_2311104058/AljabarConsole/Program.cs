using System;
using AljabarLibraries;

namespace AljabarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar-akarnya: " + string.Join(", ", akar));

            double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil kuadrat: " + string.Join(", ", hasilKuadrat));
        }
    }
}
