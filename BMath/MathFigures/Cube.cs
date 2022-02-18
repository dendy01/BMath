using System;

namespace MathFigures
{
    public class Cube
    {
        private double _side;
        public double Volume => GetVolume();

        public Cube(double side) => Side = side;

        public double Side
        {
            get => _side;

            set => _side = value > 0 ? value : 0;
        }

        public void PrintInfo() => Console.WriteLine($"Side: {Side}, Volume: {Volume}");

        public double GetVolume() => Math.Pow(_side, 3);

    }
}
