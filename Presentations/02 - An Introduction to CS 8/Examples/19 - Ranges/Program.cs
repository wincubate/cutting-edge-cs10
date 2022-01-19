using System;

namespace Wincubate.CS8.Slide19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = new string[]
            {
                "Hello",
                "World",
                "Booyah!",
                "Foobar"
            };

            foreach (var s in elements[0..^2])
            {
                Console.WriteLine( s );
            }

            // 1..
            // ..3
            // ..
            // 0..^0
        }
    }
}
