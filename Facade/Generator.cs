using System;
using System.Collections.Generic;
using System.Linq;

namespace Façade
{
    public class Generator
    {
        private static readonly Random Random = new();

        public static List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => Random.Next(1, 6))
                .ToList();
        }
    }
}