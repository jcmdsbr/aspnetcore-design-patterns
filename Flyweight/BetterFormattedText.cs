﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class BetterFormattedText
    {
        private readonly List<TextRange> formatting = new();
        private readonly string plainText;

        public BetterFormattedText(string plainText)
        {
            this.plainText = plainText;
        }

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange {Start = start, End = end};
            formatting.Add(range);
            return range;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < plainText.Length; i++)
            {
                var c = plainText[i];
                c = formatting.Where(range => range.Covers(i) && range.Capitalize)
                    .Aggregate(c, (current, range) => char.ToUpperInvariant(current));
                sb.Append(c);
            }

            return sb.ToString();
        }

        public class TextRange
        {
            public bool Capitalize, Bold, Italic;
            public int Start, End;

            public bool Covers(int position)
            {
                return position >= Start && position <= End;
            }
        }
    }
}