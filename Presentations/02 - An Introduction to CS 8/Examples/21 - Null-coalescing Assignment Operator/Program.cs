using System;

namespace Wincubate.CS8.Slide21
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int? j = 42;
            int? k = 87;

            i = i ?? j;
            i = i ?? k;

            //i ??= j ??= k; 

            Console.WriteLine( i );

            //string? s = null;
            //s ??= "Hello, World";
            //Console.WriteLine( s );
        }
    }
}
