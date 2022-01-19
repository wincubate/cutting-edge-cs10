﻿using System;
using static System.Math;

namespace Wincubate.CS8.Slide40
{
    struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public readonly override string ToString() =>
            $"({X},{Y},{Z}) at distance {DistanceFrom()} from (0,0,0)";

        public readonly double DistanceFrom(in Point3D other = default)
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
            Point3D p1 = new Point3D(-1, 0, -1);
            Console.WriteLine(p1);
        }
    }
}
