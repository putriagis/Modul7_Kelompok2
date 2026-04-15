// See https://aka.ms/new-console-template for more information
using Modul7_Kelompok2;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        ReadJSON1_103022400095();
    }

    static void ReadJSON1_103022400095()
    {
        Console.WriteLine("Hani - Film Favorit");
        String json = File.ReadAllText("jurnal7_1_103022400095.json");

        var data = JsonSerializer.Deserialize<FilmFavorit_103022400095>(json);

        Console.WriteLine("Title: " + data.title);
        Console.WriteLine("Director: " + data.director);
        Console.WriteLine("Year: " + data.year);
        Console.WriteLine("Rating: " + data.rating);
        Console.WriteLine("Duration (minutes): " + data.durationMinutes);
        Console.WriteLine("Watched: " + data.isWatched);

    }
}
