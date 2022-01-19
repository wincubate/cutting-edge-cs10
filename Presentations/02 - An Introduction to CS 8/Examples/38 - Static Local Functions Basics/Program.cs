using System;
using System.Net.Http.Headers;

namespace Wincubate.CS8.Slide38
{
    class A
    {
        public int Counter { get; set; }

        public void DisplayStatus()
        {
            static string FormatStatus( int c ) => $"Counter is {c}";

            Console.WriteLine( FormatStatus( Counter ));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A { Counter = 87 };
            a.DisplayStatus();
        }
    }

}
