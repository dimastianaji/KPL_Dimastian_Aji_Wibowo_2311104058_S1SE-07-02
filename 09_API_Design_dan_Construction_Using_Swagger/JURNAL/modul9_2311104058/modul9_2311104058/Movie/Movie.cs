using System.Collections.Generic;
using modul9_2311104058;

namespace MovieApi.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movie()
        {
            Stars = new List<string>();
        }
    }
}
