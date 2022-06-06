using DiscographyLib;
using System;

namespace Wincubate.CS7.Slide07
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album(
                "Depeche Mode",
                "Violator",
                new DateTime(1990, 3, 19)
            );

            (string summary, int age) = album;
            Console.WriteLine($"{summary} is {age} years old");
        }
    }
}
