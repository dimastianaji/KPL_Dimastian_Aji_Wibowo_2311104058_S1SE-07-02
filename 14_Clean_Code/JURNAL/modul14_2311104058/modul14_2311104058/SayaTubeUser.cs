using System;
using System.Collections.Generic;

namespace modul6_2311104058
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;

        public string Username { get; private set; }

        // Konstruktor dengan validasi username
        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Username tidak boleh null atau kosong");

            if (username.Length > 100)
                throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        // Menambahkan video ke daftar video user
        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentNullException("Video tidak boleh null");

            if (video.GetPlayCount() >= int.MaxValue)
                throw new ArgumentException("Play count video melebihi batas integer");

            uploadedVideos.Add(video);
        }

        // Mengembalikan total play count dari semua video
        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;

            foreach (var video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }

            return totalPlayCount;
        }

        // Menampilkan maksimal 8 video milik user
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");

            for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}