using System;

class Program
{
    static void Main(string[] args)
    {
        Album album = new Album(
            "Depeche Mode", 
            "Violator", 
            new DateTime(1990, 03, 19)
        );
        Console.WriteLine(album.Age);

        //album.Artist = "Somebody Else";
    }
}
