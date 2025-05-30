using System;

namespace modul6_2311104058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Konstruktor dengan validasi judul video
        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Judul video tidak boleh null atau kosong");

            if (title.Length > 200)
                throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        // Menambah jumlah play count video
        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
                throw new ArgumentException("Play count harus antara 0 dan 25.000.000");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
            }
        }

        // Menampilkan detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        // Getter untuk play count
        public int GetPlayCount()
        {
            return playCount;
        }

        // Getter untuk judul
        public string GetTitle()
        {
            return title;
        }
    }
}
