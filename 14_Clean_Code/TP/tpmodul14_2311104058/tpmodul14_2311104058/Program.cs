using System;

namespace TPModul14
{
    /// <summary>
    /// Class untuk menyapa user menggunakan method generic
    /// </summary>
    class GreetingService
    {
        /// <summary>
        /// Method generic untuk menyapa user
        /// </summary>
        /// <typeparam name="T">Tipe data user (contoh: string)</typeparam>
        /// <param name="user">Data user yang akan disapa</param>
        public void GreetUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    /// <summary>
    /// Class untuk menyimpan dan mencetak data generic
    /// </summary>
    /// <typeparam name="T">Tipe data yang akan disimpan</typeparam>
    class DataContainer<T>
    {
        private T data;

        /// <summary>
        /// Konstruktor untuk menginisialisasi data
        /// </summary>
        /// <param name="data">Data yang akan disimpan</param>
        public DataContainer(T data)
        {
            this.data = data;
        }

        /// <summary>
        /// Method untuk mencetak data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    /// <summary>
    /// Entry point program
    /// </summary>
    class Program
    {
        static void Main()
        {
            GreetingService greetingService = new GreetingService();

            // Meminta input nama dari user
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            // Menyapa user
            greetingService.GreetUser(nama);

            // Meminta input NIM dari user
            Console.Write("Masukkan NIM Anda: ");
            string nim = Console.ReadLine();

            // Membuat objek DataContainer dengan tipe string
            DataContainer<string> dataContainer = new DataContainer<string>(nim);

            // Menampilkan data
            dataContainer.PrintData();
        }
    }
}
