using System;

namespace Interpreter
{
    public class Token
    {
        public enum Type
        {
            Integer,
            Plus,
            Minus,
            Lparen,
            Rparen
        }

        public readonly Type MyType;
        public readonly string Text;

        public Token(Type type, string text)
        {
            MyType = type;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}