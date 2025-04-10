using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class KuliahMahasiswa2311104058
{
    [JsonProperty("mata_kuliah")] // Menyambungkan properti ini dengan "mata_kuliah" di JSON
    public List<MataKuliah> MataKuliah { get; set; }

    // Method untuk membaca file JSON dan menampilkan mata kuliah
    public void ReadJSON(string filePath)
    {
        try
        {
            // Periksa apakah file ada
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File tidak ditemukan! Path yang digunakan: " + Path.GetFullPath(filePath));
                return;
            }

            // Membaca isi file JSON
            string jsonContent = File.ReadAllText(filePath);
            Console.WriteLine("Isi JSON yang dibaca:");
            Console.WriteLine(jsonContent);

            // Melakukan deserialisasi file JSON menjadi objek
            KuliahMahasiswa2311104058 kuliahMahasiswa = JsonConvert.DeserializeObject<KuliahMahasiswa2311104058>(jsonContent);

            // Memeriksa apakah deserialisasi berhasil
            if (kuliahMahasiswa != null && kuliahMahasiswa.MataKuliah != null && kuliahMahasiswa.MataKuliah.Count > 0)
            {
                // Menampilkan daftar mata kuliah
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var mk in kuliahMahasiswa.MataKuliah)
                {
                    Console.WriteLine($"MK {index} {mk.KodeMatakuliah} - {mk.NamaMatakuliah}");
                    index++;
                }
            }
            else
            {
                Console.WriteLine("Data mata kuliah tidak ditemukan atau format JSON salah!");
            }
        }
        catch (Exception ex)
        {
            // Menangani jika ada kesalahan saat membaca atau mendeserialisasi file
            Console.WriteLine("Terjadi kesalahan saat membaca file: " + ex.Message);
        }
    }
}
