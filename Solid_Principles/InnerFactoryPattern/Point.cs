using System;


namespace InnerFactoryPattern
{
    public class Point
    {
        //public Point(double a, double b) // we do not want the user to create an object by making ot public -- htis is the issue with the simple factory pattern
        //{

        //}

        public Point(double a, double b)
        {

        }


        // inner factory

        public static class Factory
        {
            public static Point MakeNormalPoint(double a, double b)
            {
                return new Point(a, b);
            }

            public static Point MakeTrigonometryPoint(double cos, double sin)
            {
                return new Point(Math.Cos(cos), Math.Sin(sin));
            }
        }


    }
}
