using System;
using System.Collections.Generic;
using System.Text;
using Tree.src.Infrastructure;
using Tree.src.Interfaces;

namespace Tree.src.Implementations
{
    public class BinaryTree : ITree
    {
        private Queue<Node> _queue = new Queue<Node>();
        private Node _root;

        public int Count { get; private set; }

        public void Add(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if (_root == null)
            {
                _root = node;
                _queue.Enqueue(_root);
            }
            else
            {
                var current = _queue.Peek();

                if (current.Left == null)
                {
                    current.Left = node;
                    _queue.Enqueue(current.Left);
                }
                else if (current.Right == null)
                {
                    current.Right = node;
                    _queue.Enqueue(current.Right);
                }

                if (current.Left != null && 
                    current.Right != null)
                {
                    _queue.Dequeue();
                }
            }

            Count++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            
            if (_root == null)
            {
                sb.AppendLine("Tree is empty");
            }
            else
            {
                var queue = new Queue<Node>();
                queue.Enqueue(_root);

                sb.Append("[ ");
                while(queue.Count > 0 && queue.Peek() != null)
                {
                    var current = queue.Dequeue();
                    sb.Append($"{current.Value}");

                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }

                    if (queue.Count > 0)
                    {
                        sb.Append(", ");
                    }
                }

                sb.Append(" ]");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}