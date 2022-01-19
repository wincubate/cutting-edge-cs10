﻿using DiscographyLib;
using System;

namespace Wincubate.CS7.DeconstructingObjectsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album(
                "Depeche Mode",
                "Violator",
                new DateTime( 1990, 3, 19 )
            );

            (_, string summary, int age) = album;
            Console.WriteLine( $"{summary} is {age} years old");
        }
    }
}