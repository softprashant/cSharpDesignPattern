using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Point
    {
        public static Point MakeNormalPoint(double a, double b)
        {
            return new Point(a, b);
        }

        public static Point MakeTrigonometryPoint(double cos, double sin)
        {
            return new Point(Math.Cos(cos), Math.Sin(sin));

        }
        private Point(double a, double b)
        {

        }
    }
}
