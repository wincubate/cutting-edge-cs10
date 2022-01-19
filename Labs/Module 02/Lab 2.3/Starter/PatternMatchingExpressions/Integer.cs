namespace PatternMatchingExpressions
{
    class Integer : SimpleExpression
    {
        public int Value { get; }

        public Integer(int value)
        {
            Value = value;
        }
    }
}
