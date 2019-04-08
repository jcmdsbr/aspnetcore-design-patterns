using System.Collections.Generic;

namespace Façade
{
    public class MagicSquareGenerator
    {
        public List<List<int>> Generate(int size)
        {
            var g = new Generator();
            var s = new Splitter();
            var v = new Verifier();

            var square = new List<List<int>>();

            do
            {
                square = new List<List<int>>();
                for (var i = 0; i < size; ++i)
                    square.Add(g.Generate(size));
            } while (!v.Verify(s.Split(square)));

            return square;
        }
    }
}