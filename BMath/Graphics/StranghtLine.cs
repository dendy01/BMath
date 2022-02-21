using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMath.Graphics
{
    class Point
    {      
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class StranghtLine
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public double Coef => (A.Y - B.Y) / (A.X - B.X);

        public double Bias => A.Y - Coef * A.X;
        public delegate double Function(double value);
        public StranghtLine(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public (double k, double b) GetParameters()
        {
            double k = (A.Y - B.Y) / (A.X - B.Y);
            double b = A.Y - k * A.X;

            return (k, b);
        }
        public double Line(double x) => Coef * x + Bias;

        public void PrintInfo()
        {
            Console.WriteLine($"Y = {Coef}*x + {Bias}");
        }

    }
}
