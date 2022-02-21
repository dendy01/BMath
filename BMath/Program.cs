using MathFigures;
using BMath.Graphics;


namespace App
{
    class Program
    {
        public static void Main()
        {
            Triangle triangleHypotenuse = new RightTriangleHypotenuse(30, 5);

            triangleHypotenuse.PrintInfo();


            Triangle triangleCathets = new RightTriangleCathets(2.5, 4.33);

            triangleCathets.PrintInfo();

            
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(6);

            equilateralTriangle.PrintInfo();

            Cube cube = new Cube(5);
            cube.PrintInfo();

            Cylinder cylinder = new Cylinder(2, 4);
            cylinder.PrintInfo();


            StranghtLine line = new StranghtLine(new Point (1, 3), new Point(5, 8));
            line.PrintInfo();

        }
    }
}
