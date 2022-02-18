using System;

namespace MathFigures
{
    public class EquilateralTriangle : Triangle
    {
        public double Area => GetArea();
        public EquilateralTriangle(double side)
        {
            A = B = C = side;
            Alpha = Beta = Gamma = 60;
        }
        public double GetArea() => ((A * A) * Math.Sqrt(3)) / 4;
        public override void PrintInfo() => Console.WriteLine($"EquilateralTriangle have side: {A} and area: {Area:0.000}");
    }
}
