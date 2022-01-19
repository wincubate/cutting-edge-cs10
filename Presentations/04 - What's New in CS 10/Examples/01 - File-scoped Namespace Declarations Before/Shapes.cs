namespace Wincubate.CS10.Shapes
{
    interface IShape
    {
        double Area { get; }
    }

    record Rectangle(double Width, double Height) : IShape
    {
        public double Area => Width * Height;
    }
}