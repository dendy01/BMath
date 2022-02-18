using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigures
{
    public class RightTriangleCathets : RightTriangle
    {
        public RightTriangleCathets(double cathetA, double cathetB)
        {
            Hypotenuse = Math.Sqrt(cathetA * cathetA + cathetB * cathetB);

            (LargeCathet, SmallCathet) = cathetA > cathetB ? (cathetA, cathetB) : (cathetB, cathetA);

            Gamma = 90;

            double radian = 57.3;

            Alpha = Math.Asin(SmallCathet / Hypotenuse) * radian;
            Beta = Math.Asin(LargeCathet / Hypotenuse) * radian;
        }
    }
}
