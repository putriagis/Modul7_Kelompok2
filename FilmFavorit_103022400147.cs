using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class FilmFavorit_103022400147
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public int rating { get; set; }
    public int durationMinutes { get; set; }
    public bool isWatched { get; set; }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("D:\\vie\\Modul7_Kelompok2\\jurnal7_1_103022400147.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400147>(json);

        Console.WriteLine("judul: " + data.title + ", sutradara " + data.director + ", tahun: " + data.year + ", genre: " + data.genre + ", rating: " + data.rating +
            ", panjang film: " + data.durationMinutes + ", menit" + ", sudah ditonton: " + data.isWatched);
    }
}