using System;

namespace Wincubate.CS8.Slide18
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

            Console.WriteLine(elements[^1]);

            Index i = ^2;
            Console.WriteLine(elements[i]);
        }
    }
}
