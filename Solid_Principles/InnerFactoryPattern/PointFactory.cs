using System;
using InnerFactoryPattern;

public static class PointFactory
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