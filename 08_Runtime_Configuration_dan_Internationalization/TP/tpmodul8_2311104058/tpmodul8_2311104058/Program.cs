using System;
using tpmodul8_2311104058;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        config.UbahSatuan();

        string satuan = config.satuan_suhu;
        int batasHari = config.batas_hari_deman;
        string pesanDiterima = config.pesan_diterima;
        string pesanDitolak = config.pesan_ditolak;

        try
        {
            Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {satuan}: ");
            double suhu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
            int hariDemam = Convert.ToInt32(Console.ReadLine());

            bool suhuNormal = false;

            if (satuan == "celcius")
            {
                suhuNormal = suhu >= 36.5 && suhu <= 37.5;
            }
            else if (satuan == "fahrenheit")
            {
                suhuNormal = suhu >= 97.7 && suhu <= 99.5;
            }

            if (suhuNormal && hariDemam < batasHari)
            {
                Console.WriteLine(pesanDiterima);
            }
            else
            {
                Console.WriteLine(pesanDitolak);
            }
        }
        catch
        {
            Console.WriteLine("Input tidak valid. Silakan masukkan angka yang benar.");
        }
    }
}
