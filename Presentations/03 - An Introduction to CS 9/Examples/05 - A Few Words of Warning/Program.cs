using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Album album1 = new Album("Depeche Mode", "Violator", new DateTime(1990, 03, 19));
        Album album2 = new Album("Depeche Mode", "The Singles", new DateTime(2001, 12, 24));
        Console.WriteLine(album1);

        Single single1 = new Single(
            "Depeche Mode", 
            "Enjoy the Silence", 
            new DateTime(1990, 1, 1), 
            new Album[] { album1, album2 });
        Single single2 = new Single(
            "Depeche Mode",
            "Enjoy the Silence",
            new DateTime(1990, 1, 1),
            new Album[] { album1, album2 });

        Console.WriteLine(single1 == single2);
    }
}

abstract record Record(string Artist, string Name, DateTime? ReleaseDate = default)
{
    public int? Age
    {
        get
        {
            if (ReleaseDate.HasValue)
            {
                DateTime today = DateTime.Now;
                return today.Year - ReleaseDate.Value.Year - (ReleaseDate.Value.DayOfYear < today.DayOfYear ? 0 : 1);
            }

            return null;
        }
    }
}

sealed record Single(string Artist, string Name, DateTime? ReleaseDate, IEnumerable<Album>? Albums)
    : Record(Artist, Name, ReleaseDate)
{
    public override string ToString()
    {
        string albums = string.Join("-", Albums ?? new Album[0]);

        return $"{Artist}: \"{Name}\" [{ReleaseDate}] - From the album(s) \"{albums}\"";
    }
}

record Album(string Artist, string Name, DateTime? ReleaseDate, int NumberOfDiscs = 1)
    : Record(Artist, Name, ReleaseDate);