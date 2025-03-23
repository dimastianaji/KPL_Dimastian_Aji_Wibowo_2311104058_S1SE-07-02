using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2_2311104058
{
    class Salam
    {
        public string Nama { get; set; }

        public void InputNama()
        {
            Console.Write("Masukkan nama Anda: ");
            Nama = Console.ReadLine();
        }

        public void TampilkanSalam()
        {
            Console.WriteLine($"Selamat datang, {Nama}!");
        }
    }

}
