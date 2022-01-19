namespace PatternMatchingExpressions
{
    class Add : SimpleExpression
    {
        public SimpleExpression Left { get; }
        public SimpleExpression Right { get; }

        public Add(SimpleExpression left, SimpleExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
