namespace Adapter.NoCaching
{
    public class Line
    {
        public readonly Point End;
        public readonly Point Start;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}