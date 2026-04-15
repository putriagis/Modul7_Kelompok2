using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_Kelompok2
{

    class Watchlist_103022400095
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movies> movies { get; set; }
    }
    
    class Movies
    {
        public string id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public double rating { get; set; }
    }
}
