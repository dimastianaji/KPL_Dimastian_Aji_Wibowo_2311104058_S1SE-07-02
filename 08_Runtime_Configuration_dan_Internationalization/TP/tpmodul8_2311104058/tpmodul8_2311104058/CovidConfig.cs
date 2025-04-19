using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            LoadConfig();
        }

        public void LoadConfig()
        {
            if (File.Exists(ConfigFileName))
            {
                string json = File.ReadAllText(ConfigFileName);
                var config = JsonSerializer.Deserialize<CovidConfig>(json);
                this.satuan_suhu = config.satuan_suhu;
                this.batas_hari_deman = config.batas_hari_deman;
                this.pesan_ditolak = config.pesan_ditolak;
                this.pesan_diterima = config.pesan_diterima;
            }
            else
            {
                SaveConfig(); // Buat file default
            }
        }

        public void SaveConfig()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(ConfigFileName, json);
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
    }
}
