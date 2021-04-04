using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace Adapter.NoCaching
{
    public static class Demo
    {
        private static readonly List<VectorObject> VectorObjects = new()
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        private static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        public static void Main()
        {
            Draw();
            Draw();
        }

        private static void Draw()
        {
            foreach (var adapter in from vo in VectorObjects from line in vo select new LineToPointAdapter(line))
                adapter.ForEach(DrawPoint);
        }
    }
}