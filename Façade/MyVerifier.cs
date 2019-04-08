using System.Collections.Generic;

namespace Coding.Exercise.Tests
{
    public class MyVerifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any()) return false;

            var rowCount = array.Count;
            var colCount = array[0].Count;

            var expected = array.First().Sum();

            for (var row = 0; row < rowCount; ++row)
                if (array[row].Sum() != expected)
                    return false;

            for (var col = 0; col < colCount; ++col)
                if (array.Select(a => a[col]).Sum() != expected)
                    return false;

            var diag1 = new List<int>();
            var diag2 = new List<int>();
            for (var r = 0; r < rowCount; ++r)
            for (var c = 0; c < colCount; ++c)
            {
                if (r == c)
                    diag1.Add(array[r][c]);
                var r2 = rowCount - r - 1;
                if (r2 == c)
                    diag2.Add(array[r][c]);
            }

            return diag1.Sum() == expected && diag2.Sum() == expected;
        }
    }
}

}