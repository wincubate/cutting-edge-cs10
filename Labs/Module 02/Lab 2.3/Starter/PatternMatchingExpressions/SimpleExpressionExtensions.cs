using System;

namespace PatternMatchingExpressions
{
    static class SimpleExpressionExtensions
    {
        // TODO: Complete Display()
        public static string Display(this SimpleExpression expression) => "?";

        // TODO: Complete BetterDisplay()
        public static string BetterDisplay(this SimpleExpression expression) => "?";

        // TODO: Complete Evaluate()
        public static int Evaluate(this SimpleExpression expression) =>
            throw new ArgumentException("Illegal expression argument");
    }
}