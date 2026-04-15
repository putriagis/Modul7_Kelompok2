using System;
using System.Collections.Generic;

public class WatchList
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
}

public class Watchlist_103022400115
{
    public string watchlistName {  get; set; }
    public string createdBy { get; set; }
    
    public List<WatchList> film {  get; set; }
}
