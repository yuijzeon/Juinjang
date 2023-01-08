using System;
using System.Drawing;

namespace Oval_Measure
{
    public static class PointHelper
    {
        public static double Distance(Point point, Point another)
        {
            return Math.Sqrt(Math.Pow(another.X - point.X, 2) +  Math.Pow(another.Y - point.Y, 2));
        }
    }
}