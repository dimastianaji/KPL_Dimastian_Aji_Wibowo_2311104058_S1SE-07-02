using System;
using tpmodul8_2311104058;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        config.LoadConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}:");
        if (!double.TryParse(Console.ReadLine(), out double suhuBadan))
        {
            Console.WriteLine("Input suhu tidak valid!");
            return;
        }

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        if (!int.TryParse(Console.ReadLine(), out int hariDeman))
        {
            Console.WriteLine("Input hari demam tidak valid!");
            return;
        }

        config.CekMasukGedung(suhuBadan, hariDeman);

        Console.WriteLine("Ingin mengganti satuan suhu? (Y/N):");
        string ubahSatuan = Console.ReadLine();
        if (ubahSatuan.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            config.UbahSatuan();
        }
    }
}