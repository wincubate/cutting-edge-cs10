using System;

namespace Wincubate.CS10.Shapes;

record Circle(double Radius) : IShape
{
    public double Area => Math.PI*Math.Pow(Radius,2);

    public string Serialize() => JsonSerializer.Serialize(this);
}
