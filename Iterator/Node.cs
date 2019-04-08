namespace Iterator
{
    public class Node<T>
    {
        public Node<T> Left, Right;
        public Node<T> Parent;
        public T Value;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }
    }
}