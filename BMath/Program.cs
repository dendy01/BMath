using MathFigures;

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

        }
    }

}
