using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Façade;
using NUnit.Framework;

namespace Coding.Exercise.Tests
{
    [TestFixture]
    public class TestSuite
    {
        private string SquareToString(List<List<int>> square)
        {
            var sb = new StringBuilder();
            foreach (var row in square)
                sb.AppendLine(string.Join(" ",
                    row.Select(x => x.ToString())));

            return sb.ToString();
        }

        [Test]
        public void TestSizeThree()
        {
            var gen = new MagicSquareGenerator();
            var square = gen.Generate(3);

            Console.WriteLine(SquareToString(square));

            var v = new MyVerifier(); // prevents cheating :)
            Assert.IsTrue(v.Verify(square),
                "Verification failed: this is not a magic square");
        }
    }
}

}