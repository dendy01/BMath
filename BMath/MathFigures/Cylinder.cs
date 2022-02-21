using System;

namespace MathFigures
{
    class Cylinder
    {
        private double _height;
        private double _radius;

        public double Volume => GetVolume();          
        

        public double Height
        {
            get => _height;            
            set => _height = value;          
        }

        public double Radius
        {
            get => _radius;           
            set => _radius = value;
        }

        public Cylinder(double radius, double height) 
        {
            Radius = radius; 
            Height = height;
        }
        
        public double GetVolume() => Math.PI * Math.Pow(_radius, 2) * _height;
        
        public void PrintInfo() => Console.WriteLine($"Radius:{Radius}, Height:{Height}, Volume:{Volume:0.00}");       
    }
}
