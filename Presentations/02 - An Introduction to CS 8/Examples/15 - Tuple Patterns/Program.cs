using System;
using System.Linq;

namespace Wincubate.CS8.Slide15
{
    enum Hand
    {
        Paper,
        Scissors,
        Rock
    }

    enum Outcome
    {
        Left,
        Right,
        Tie
    }

    class Program
    {
        public static T GetRandomMember<T>() where T : struct, Enum
        {
            Random random = new Random();
            T[] ts = Enum.GetValues(typeof(T))
                .OfType<T>()
                .ToArray()
                ;

            return ts[random.Next(ts.Length)];
        }

        static void Main(string[] args)
        {
            Hand left = GetRandomMember<Hand>();
            Hand right = GetRandomMember<Hand>();

            Outcome winner = (left, right) switch
            {
                (Hand.Paper, Hand.Rock) => Outcome.Left,
                (Hand.Paper, Hand.Scissors) => Outcome.Right,
                (Hand.Rock, Hand.Paper) => Outcome.Right,
                (Hand.Rock, Hand.Scissors) => Outcome.Left,
                (Hand.Scissors, Hand.Paper) => Outcome.Left,
                (Hand.Scissors, Hand.Rock) => Outcome.Right,
                (_,_) => Outcome.Tie
            };

            Console.WriteLine( $"{left} vs {right}:\t{winner}");
        }
    }
}
