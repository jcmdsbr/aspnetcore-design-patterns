using System.Collections.Generic;

namespace Façade
{
    public class Splitter
    {
        public List<List<int>> Split(List<List<int>> array)
        {
            var result = new List<List<int>>();

            var rowCount = array.Count;
            var colCount = array[0].Count;

            // get the rows
            for (var r = 0; r < rowCount; ++r)
            {
                var theRow = new List<int>();
                for (var c = 0; c < colCount; ++c)
                    theRow.Add(array[r][c]);
                result.Add(theRow);
            }

            // get the columns
            for (var c = 0; c < colCount; ++c)
            {
                var theCol = new List<int>();
                for (var r = 0; r < rowCount; ++r)
                    theCol.Add(array[r][c]);
                result.Add(theCol);
            }

            // now the diagonals
            var diag1 = new List<int>();
            var diag2 = new List<int>();
            for (var c = 0; c < colCount; ++c)
            for (var r = 0; r < rowCount; ++r)
            {
                if (c == r)
                    diag1.Add(array[r][c]);
                var r2 = rowCount - r - 1;
                if (c == r2)
                    diag2.Add(array[r][c]);
            }

            result.Add(diag1);
            result.Add(diag2);

            return result;
        }
    }
}