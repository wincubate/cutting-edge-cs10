using System;

namespace PatternMatchingExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleExpression expression = new Add(
                new Negative(
                    new Integer(-176)
                ),
                new Add(
                    new Integer(-42),
                    new Multiply(
                        new Integer(1),
                        new Integer(87)
                    )
                )
            );

            Console.WriteLine(expression.Display());
            Console.WriteLine(expression.BetterDisplay());
            Console.WriteLine(expression.Evaluate());
        }
    }
}