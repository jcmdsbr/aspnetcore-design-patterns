namespace Factories
{
    internal class PointFactory
    {
        public static Point NewCartesianPoint(float x, float y)
        {
            return new(x, y); // needs to be public
        }
    }
}