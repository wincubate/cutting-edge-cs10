﻿namespace Wincubate.CS10.Shapes;

record Rectangle(double Width, double Height) : IShape
{
    public double Area => Width * Height;

    public string Serialize() => JsonSerializer.Serialize(this);
}