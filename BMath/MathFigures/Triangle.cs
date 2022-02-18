using System;

namespace MathFigures
{
    public class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double Alpha;
        public double Beta;
        public double Gamma;

        public virtual void PrintInfo()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
            Console.WriteLine($"Alpha: { Alpha}, Beta: {Beta}, Gamma:{Gamma}");
        }
    }
}
