using System;
using static System.Math;

namespace Wincubate.CS8.Slide40
{
    readonly struct Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() =>
            $"({X},{Y},{Z}) at distance {DistanceFrom()} from (0,0,0)";

        public double DistanceFrom(in Point3D other = default)
        {
            double xDiff = X - other.X;
            double yDiff = Y - other.Y;
            double zDiff = Z - other.Z;

            return Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D( -1, 0, -1 );
            Console.WriteLine( p1 );
        }
    }
}
