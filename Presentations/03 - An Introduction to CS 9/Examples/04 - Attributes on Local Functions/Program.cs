using System;

namespace Wincubate.CS9.D
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintInfo(string s)
            {
                Console.WriteLine($"Debug: {s}");
            }

            PrintInfo("Start");
            Console.WriteLine("Info: Program is running...");
            PrintInfo("Stop");
        }
    }
}
