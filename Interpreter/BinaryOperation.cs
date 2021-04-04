using System;

namespace Interpreter
{
    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition,
            Subtraction
        }

        public IElement Left, Right;

        public Type MyType;

        public int Value
        {
            get
            {
                return MyType switch
                {
                    Type.Addition => Left.Value + Right.Value,
                    Type.Subtraction => Left.Value - Right.Value,
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}