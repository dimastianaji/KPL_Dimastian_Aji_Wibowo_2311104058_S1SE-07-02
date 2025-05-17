using modul13_2311104058;

class Program
{
    static void Main(string[] args)
    {
        // A & B
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // C. Tambah nama anggota kelompok dan asisten
        data1.AddSebuahData("Anggota 1 - Dimastian");
        data1.AddSebuahData("Anggota 2 - Fahmi");
        data1.AddSebuahData("Anggota 3 - Rifqi");
        data1.AddSebuahData("Anggota 4 - Berlian");
        data1.AddSebuahData("Asisten 1 - Kak Gideon");
        data1.AddSebuahData("Asisten 2 - Kak Devrin");

        // D. Cetak semua data melalui data2
        Console.WriteLine("Data2 - Sebelum penghapusan:");
        data2.PrintSemuaData();

        // E. Hapus dua asisten dari index 4 dan 5
        data2.HapusSebuahData(5);
        data2.HapusSebuahData(4); 

        // F. Print ulang melalui data1
        Console.WriteLine("\nData1 - Setelah penghapusan:");
        data1.PrintSemuaData();

        // G. Tampilkan jumlah elemen dari list pada kedua objek
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
