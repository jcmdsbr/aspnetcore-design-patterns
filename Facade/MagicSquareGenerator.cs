using System.Collections.Generic;

namespace Façade
{
    public class MagicSquareGenerator
    {
        public static List<List<int>> Generate(int size)
        {
            var g = new Generator();
            var s = new Splitter();
            var v = new Verifier();

            List<List<int>> square;

            do
            {
                square = new List<List<int>>();
                for (var i = 0; i < size; ++i)
                    square.Add(Generator.Generate(size));
            } while (!v.Verify(Splitter.Split(square)));

            return square;
        }
    }
}