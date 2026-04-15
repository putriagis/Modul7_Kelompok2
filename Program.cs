// See https://aka.ms/new-console-template for more information

using Modul7_Kelompok2;
using System.Text.Json;

namespace Modul7_kelompok2
{
    class program
    {
        static void Main(string[] args)
        {
            readJSON_putri();
            Console.WriteLine();

            static void readJSON_putri()
            {
                string json = File.ReadAllText("jurnal7_1_103022400081");
                var data = JsonSerializer.Deserialize<FilmFavorite_103022400081>(json);
                Console.WriteLine("Title: " + data.title);
                Console.WriteLine("Direction: " + data.direction);
                Console.WriteLine("Year: " + data.year);
                Console.WriteLine("Genre: " + data.genre);
                Console.WriteLine("Rating: " + data.rating);
                Console.WriteLine("Duration Minutes: " + data.durationMinutes);
                Console.WriteLine("Is Watched: " + data.isWatched);
            }
        }
    }
}














