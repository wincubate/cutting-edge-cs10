using System;
using System.Collections;
using System.Collections.Generic;

namespace Wincubate.CS8.Slide29
{
    class Program
    {
        static void Main()
        {
            string[] words = new string[] { "Hello", "World", "Booyah!" };

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            //var enumerator = words.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
        }

        //static IEnumerable<string> GetStrings()
        //{
        //    yield return "Hello";
        //    yield return "World";
        //    yield return "Booyah!";
        //}
    }
}
