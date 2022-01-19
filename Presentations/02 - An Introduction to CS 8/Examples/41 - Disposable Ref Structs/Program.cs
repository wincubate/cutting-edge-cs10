using System;

namespace Wincubate.CS8.Slide41
{
    ref struct Point3D
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

        public override string ToString() => $"({X},{Y},{Z})";

        //public void Dispose()
        //{
        //    Console.WriteLine("Disposing... :-)");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(1, 0, 1);
            //object o = point;

            Console.WriteLine(point.ToString());
        }
    }
}
