using Newtonsoft.Json;

public class MataKuliah
{
    [JsonProperty("kode_matakuliah")]  // Menyambungkan "kode_matakuliah" di JSON ke properti ini
    public string KodeMatakuliah { get; set; }

    [JsonProperty("nama_matakuliah")]  // Menyambungkan "nama_matakuliah" di JSON ke properti ini
    public string NamaMatakuliah { get; set; }
}