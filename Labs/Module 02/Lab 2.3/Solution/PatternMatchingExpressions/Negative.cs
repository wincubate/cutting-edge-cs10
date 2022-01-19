namespace PatternMatchingExpressions
{
    class Negative : SimpleExpression
    {
        public SimpleExpression Inner { get; }

        public Negative(SimpleExpression inner)
        {
            Inner = inner;
        }

        public void Deconstruct(out SimpleExpression inner)
        {
            inner = Inner;
        }
    }
}
