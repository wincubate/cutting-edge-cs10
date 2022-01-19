using System;

namespace Wincubate.CS8.Slide43
{
    class Program
    {
        static void Main(string[] args)
        {
            Span<int> numbers = stackalloc[] { 11, 22, 33, 42, 44, 87, 88 };
            int index = numbers.IndexOfAny(stackalloc[] { 42, 87 });
            
            Console.WriteLine(index);
        }
    }
}
