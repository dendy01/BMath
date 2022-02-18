using System;

namespace MathFigures
{
    public class RightTriangle : Triangle
    {
        public double LargeCathet { get; set; }
        public double SmallCathet { get; set; }
        public double Area => GetArea();
        public double Hypotenuse { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }

        public RightTriangle()
        {

        }
        public double GetArea()
        {
            return (LargeCathet * SmallCathet) / 2;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"LargeCathet: {LargeCathet:0.000},SmallCathet: {SmallCathet:0.000},Hypotenuse: {Hypotenuse:0.000} ");
            Console.WriteLine($"Alpha: {Alpha:0.000}, Beta: {Beta:0.000}, Gamma: {Gamma:0.000}");
        }
    }
}
