using System.Collections.Generic;

namespace Iterator
{
    public class BinaryTree<T>
    {
        private readonly Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public IEnumerable<Node<T>> NaturalInOrder
        {
            get
            {
                static IEnumerable<Node<T>> TraverseInOrder(Node<T> current)
                {
                    if (current.Left != null)
                        foreach (var left in TraverseInOrder(current.Left))
                            yield return left;
                    yield return current;
                    if (current.Right != null)
                        foreach (var right in TraverseInOrder(current.Right))
                            yield return right;
                }

                foreach (var node in TraverseInOrder(root))
                    yield return node;
            }
        }

        public InOrderIterator<T> GetEnumerator()
        {
            return new(root);
        }
    }
}