namespace PatternMatchingExpressions
{
    class Negative : SimpleExpression
    {
        public SimpleExpression Inner { get; }

        public Negative(SimpleExpression inner)
        {
            Inner = inner;
        }
    }
}
