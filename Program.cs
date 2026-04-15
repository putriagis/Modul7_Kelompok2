// See https://aka.ms/new-console-template for more information

using System.Text.Json;

namespace Modul7_Kelompok2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadJSON1_103022400115();
            ReadJSON2_103022400115();
        }

        static void ReadJSON1_103022400115()
        {
            string json = File.ReadAllText("D:\\Modul7_Kelompok2\\jurnal7_1_103022400115.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400115>(json);
            Console.WriteLine("Judul: " + data.title);
            Console.WriteLine("Sutradara: " + data.director);
            Console.WriteLine("Tahun: " + data.year);
            Console.WriteLine("Genre: " + data.genre);
            Console.WriteLine("Rating: " + data.rating);
            Console.WriteLine("Durasi: " + data.durationMinutes + " menit");
            Console.WriteLine("isWatched: " + data.isWatched);
        }

        static void ReadJSON2_103022400115()
        {
            string json = File.ReadAllText("D:\\Modul7_Kelompok2\\jurnal7_2_103022400115.json");
            var data = JsonSerializer.Deserialize<Watchlist_103022400115>(json);
            Console.WriteLine("Watchlist Name : " + data.watchlistName);
            Console.WriteLine("Created By : " + data.createdBy);
            Console.WriteLine("Movies : ");
            int i = 1;
            foreach (var film in data.film)
            {
                Console.WriteLine(film.id + " " + film.title + " " + "(" + film.year + "-" + film.rating); ;
            }
        }
    }
}