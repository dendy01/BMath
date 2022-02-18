using System;

namespace MathFigures
{
    public class RightTriangleHypotenuse : RightTriangle
    {
        public RightTriangleHypotenuse(double angle, double hypotenuse)
        {
            double radiane = angle * Math.PI / 180;

            Alpha = angle;
            Gamma = 90;

            double cathetA = Math.Sin(radiane) * hypotenuse;
            double cathetB = Math.Cos(radiane) * hypotenuse;

            (LargeCathet, SmallCathet) = cathetA > cathetB ? (cathetA, cathetB) : (cathetB, cathetA);

            Hypotenuse = hypotenuse;

            Beta = Math.Asin(LargeCathet / Hypotenuse) * 57.3;
        }
    }
}
