using System;

class Nama
{
    public string depan { get; set; } = "";   // Tambahkan nilai default untuk menghindari error null
    public string belakang { get; set; } = "";
}

class Mahasiswa
{
    public Nama nama { get; set; } = new Nama();  // Inisialisasi dengan objek kosong
    public long nim { get; set; }
    public string fakultas { get; set; } = "";
}
