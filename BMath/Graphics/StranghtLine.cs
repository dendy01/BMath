using System;

namespace BMath.Graphics
{
    class StranghtLine
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public double Coef => (A.Y - B.Y) / (A.X - B.X);

        public double Bias => A.Y - Coef * A.X;

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
