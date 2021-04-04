using System;

namespace Factories
{
    public class Point
    {
        // singleton field
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double a,
            double b, // names do not communicate intent
            CoordinateSystem cs = CoordinateSystem.Cartesian)
        {
            switch (cs)
            {
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                case CoordinateSystem.Cartesian:
                    break;
                default:
                    x = a;
                    y = b;
                    break;
            }

            // steps to add a new system
            // 1. augment CoordinateSystem
            // 2. change ctor
        }

        // factory property

        public static Point Origin => new(0, 0);

        // factory method

        public static Point NewCartesianPoint(double x, double y)
        {
            return new(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            //...
            return null;
        }
    }
}