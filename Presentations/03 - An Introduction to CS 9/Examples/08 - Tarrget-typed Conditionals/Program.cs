using System;

namespace Wincubate.CS9.C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            int i = 87;

            Console.WriteLine($"Result: {( b ? i : null)}");

            //M(b ? 1 : 2);

            //M(b switch
            //{
            //    true => 1,
            //    false => 2
            //});

            //var xyz = b switch
            //{
            //    true => 1,
            //    false => 2
            //};
        }

        static void M(short _)
        {
            Console.WriteLine( "Called with a short");
        }

        static void M(long _)
        {
            Console.WriteLine("Called with a long");
        }
    }
}
