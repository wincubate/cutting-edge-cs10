using System;

namespace PatternMatchingExpressions
{
    static class SimpleExpressionExtensions
    {
        // TODO: Complete Display()
        public static string Display(this SimpleExpression expression) =>
        expression switch
        {
            Integer integer => integer.Value.ToString(),
            Negative(var inner) => $"-({inner.Display()})",
            Add(var left, var right) => $"({left.Display()})+({right.Display()})",
            Multiply(var left, var right) => $"({left.Display()})*({right.Display()})",
            null => "null",
            _ => "?"
        };

        // TODO: Complete BetterDisplay()
        public static string BetterDisplay(this SimpleExpression expression) =>
            expression switch
            {
                Negative(Integer(0)) => "0",
                Negative(Integer(int a)) when a > 0 => (-a).ToString(),
                Negative(Integer(int a)) when a < 0 => (-a).ToString(),
                Negative(SimpleExpression e) => $"-{e.BetterDisplay()}",
                Integer(int a) => a.ToString(),
                Add(Integer(0), SimpleExpression right) => right.BetterDisplay(),
                Add(SimpleExpression left, Integer(0)) => left.BetterDisplay(),
                Add(Integer(int a), SimpleExpression right) => $"{a}+{right.BetterDisplay()}",
                Add(SimpleExpression left, Integer(int b)) => $"{left.BetterDisplay() + b}",
                Add(var left, var right) => $"({left.BetterDisplay()})+({right.BetterDisplay()})",
                Multiply(Integer(0), _) => "0",
                Multiply(_, Integer(0)) => "0",
                Multiply(Integer(1), SimpleExpression e) => e.BetterDisplay(),
                Multiply(SimpleExpression e, Integer(1)) => e.BetterDisplay(),
                Multiply(Integer(int a), Integer(int b)) => $"{a}*{b}",
                Multiply(Integer(int a), SimpleExpression right) => $"{a}*({right.BetterDisplay()})",
                Multiply(SimpleExpression left, Integer(int b)) => $"({left.BetterDisplay()})*{b}",
                Multiply(var left, var right) => $"({left.BetterDisplay()})*({right.BetterDisplay()})",
                _ => "?"
            };

        // TODO: Complete Evaluate()
        public static int Evaluate(this SimpleExpression expression) =>
            expression switch
            {
                Integer integer => integer.Value,
                Negative(var inner) => -inner.Evaluate(),
                Add(var left, var right) => left.Evaluate() + right.Evaluate(),
                Multiply(var left, var right) => left.Evaluate() * right.Evaluate(),
                _ => throw new ArgumentException("Illegal expression argument")
            };
    }
}