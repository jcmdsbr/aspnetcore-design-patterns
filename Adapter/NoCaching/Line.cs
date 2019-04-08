namespace Adapter.NoCaching
{
    public class Line
    {
        public Point End;
        public Point Start;

        public Line()
        {
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}