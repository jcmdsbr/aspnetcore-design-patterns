using System.Text;

namespace Flyweight
{
    public class FormattedText
    {
        private readonly bool[] capitalize;
        private readonly string plainText;

        public FormattedText(string plainText)
        {
            this.plainText = plainText;
            capitalize = new bool[plainText.Length];
        }

        public void Capitalize(int start, int end)
        {
            for (var i = start; i <= end; ++i)
                capitalize[i] = true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < plainText.Length; i++)
            {
                var c = plainText[i];
                sb.Append(capitalize[i] ? char.ToUpper(c) : c);
            }

            return sb.ToString();
        }
    }
}