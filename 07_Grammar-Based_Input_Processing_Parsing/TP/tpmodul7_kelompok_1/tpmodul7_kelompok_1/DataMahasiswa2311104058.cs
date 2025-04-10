using System;
using System.IO;
using Newtonsoft.Json;

class DataMahasiswa2311104058
{
    public static void ReadJSON()
    {
        string path = "tp7_1_2311104058.json";
        Console.WriteLine($"🔍 Mencari file di lokasi: {Path.GetFullPath(path)}");

        if (!File.Exists(path))
        {
            Console.WriteLine("❌ File JSON tidak ditemukan!");
            return;
        }

        try
        {
            string json = File.ReadAllText(path);
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(json)!;

            Console.WriteLine($"✅ Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"❌ Terjadi kesalahan saat membaca JSON: {e.Message}");
        }
    }
}
