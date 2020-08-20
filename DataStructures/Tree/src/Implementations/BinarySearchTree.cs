using System;
using System.Collections.Generic;
using System.Text;
using Tree.src.Infrastructure;
using Tree.src.Interfaces;

namespace Tree.src.Implementations
{
    public class BinarySearchTree : ITree
    {
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
            }
            else
            {
                Insert(_root, node);
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

        private void Insert(Node root, Node node)
        {
            if (node.Value.GetHashCode() <= root.Value.GetHashCode())
            {
                if (root.Left == null)
                {
                    root.Left = node;
                }
                else
                {
                    Insert(root.Left, node);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = node;
                }
                else
                {
                    Insert(root.Right, node);
                }
            }
        }
    }
}