namespace PatternMatchingExpressions
{
    class Multiply : SimpleExpression
    {
        public SimpleExpression Left { get; }
        public SimpleExpression Right { get; }

        public Multiply(SimpleExpression left, SimpleExpression right)
        {
            Left = left;
            Right = right;
        }

        public void Deconstruct(out SimpleExpression left, out SimpleExpression right)
        {
            left = Left;
            right = Right;
        }
    }
}
