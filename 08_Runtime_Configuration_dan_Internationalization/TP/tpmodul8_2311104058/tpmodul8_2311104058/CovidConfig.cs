using System;
using System.IO;
using System.Text.Json;

namespace tpmodul8_2311104058
{
    public class CovidConfig
    {
        private const string ConfigFileName = "covid_config.json";

        public string satuan_suhu { get; set; } = "celcius";
        public int batas_hari_deman { get; set; } = 14;
        public string pesan_ditolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string pesan_diterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        public CovidConfig()
        {
        }

        public void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFileName))
                {
                    string json = File.ReadAllText(ConfigFileName);
                    CovidConfig? config = JsonSerializer.Deserialize<CovidConfig>(json);

                    if (config != null)
                    {
                        this.satuan_suhu = config.satuan_suhu;
                        this.batas_hari_deman = config.batas_hari_deman;
                        this.pesan_ditolak = config.pesan_ditolak;
                        this.pesan_diterima = config.pesan_diterima;
                    }
                    else
                    {
                        Console.WriteLine("Config JSON tidak valid. Menggunakan konfigurasi default.");
                        SaveConfig();
                    }
                }
                else
                {
                    SaveConfig(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat membaca config: {ex.Message}");
                SaveConfig(); 
            }
        }
        public void SaveConfig()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(this, options);
                File.WriteAllText(ConfigFileName, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat menyimpan config: {ex.Message}");
            }
        }
        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else
            {
                satuan_suhu = "celcius";
            }
            SaveConfig();
            Console.WriteLine($"Satuan suhu berhasil diubah ke: {satuan_suhu}");
        }
        public void CekMasukGedung(double suhuBadan, int hariDeman)
        {
            bool suhuValid = false;
            if (satuan_suhu == "celcius")
            {
                suhuValid = suhuBadan >= 36.5 && suhuBadan <= 37.5;
            }
            else if (satuan_suhu == "fahrenheit")
            {
                suhuValid = suhuBadan >= 97.7 && suhuBadan <= 99.5;
            }

            if (suhuValid && hariDeman < batas_hari_deman)
            {
                Console.WriteLine(pesan_diterima);
            }
            else
            {
                Console.WriteLine(pesan_ditolak);
            }
        }
    }
}
