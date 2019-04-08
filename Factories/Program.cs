namespace Factories
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Point(2, 3, CoordinateSystem.Cartesian);

            var origin = Point.Origin;

            var p2 = PointFactory.NewCartesianPoint(1, 2);

            var p3 = Point.NewCartesianPoint(1, 2);
        }
    }
}