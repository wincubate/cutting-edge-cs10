using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence<int> sequence = new Sequence<int>
            {
                42, 87, 112, 176, 256
            };

            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }
    }
}
