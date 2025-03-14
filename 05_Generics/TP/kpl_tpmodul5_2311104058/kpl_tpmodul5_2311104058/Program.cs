using System;

class HaloGeneric
{
    // Method generic untuk menyapa user
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    private T data;

    // Konstruktor untuk menginisialisasi data
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method untuk mencetak data
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();

        // Meminta input nama dari user
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        // Memanggil method dengan input dari user
        halo.SapaUser(nama);

        // Meminta input NIM dari user
        Console.Write("Masukkan NIM Anda: ");
        string nim = Console.ReadLine();

        // Membuat objek DataGeneric dengan tipe string
        DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

        // Memanggil method PrintData
        dataGeneric.PrintData();
    }
}