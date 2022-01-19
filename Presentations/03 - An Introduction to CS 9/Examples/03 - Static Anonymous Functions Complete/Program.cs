using System;
using static System.Console;

namespace Wincubate.CS9.D
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Onomatopoiea";

            var t = FindVowels(input);
            WriteLine($"There are {t.vowels} vowels and {t.cons} consonants in \"{input}\"");
        }

        static (int vowels, int cons) FindVowels(string s)
        {
            var tuple = (v: 0, c: 0);

            foreach (char letter in s)
            {
                static bool IsVowel(char letter) => char.ToLower(letter) switch
                {
                    'a' or 'e' or 'i' or 'o' or 'u' or 'y' or 'æ' or 'ø' or 'å' => true,
                    _ => false,
                };

                if (IsVowel(letter))
                {
                    tuple.v++;
                }
                else if (char.IsLetter(letter))
                {
                    tuple.c++;
                }
            }

            return tuple;
        }
    }
}