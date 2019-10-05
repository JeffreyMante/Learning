using System;
using System.Text;
using LinkedList.src.Interfaces;
using LinkedList.src.Infrastructure;

namespace LinkedList.src.Implementations
{
    public sealed class NodeLinkedList : ILinkedList
    {
        private Node _tail;
        private Node _head;
        private int _count;

        public int Count => _count;

        public void Add (object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = _tail.Next;
            }

            _count++;
        }

        public void Remove (object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var current = _head;
            while (current != null)
            {
                if (Equals(current.Value, value))
                {
                    _head = current.Next;
                    _count--;
                }
                else if (Equals(current.Next?.Value, value))
                {
                    current.Next = current.Next.Next;
                    _count--;

                    if (Equals(current.Next?.Value, value))
                    {
                        continue;
                    }
                }

                current = current.Next;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();

            if (Count == 0)
            {
                sb.AppendLine("The list is empty");
                return sb.ToString();
            }

            sb.AppendLine($"Count: {Count}");
            sb.AppendLine();

            var current = _head;
            var i = 0;

            while(current != null)
            {
                sb.AppendLine($"[{i++}] {current.Value}");
                current = current.Next;
            }

            return sb.ToString();
        }
    }
}