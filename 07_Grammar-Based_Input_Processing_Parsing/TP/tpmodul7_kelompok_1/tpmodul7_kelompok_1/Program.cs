using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Membaca Data Mahasiswa ===");
        DataMahasiswa2311104058.ReadJSON();

        string filePath = @"tp7_2_2311104058.json";  

        KuliahMahasiswa2311104058 kuliah = new KuliahMahasiswa2311104058();

        kuliah.ReadJSON(filePath);
    }
}
