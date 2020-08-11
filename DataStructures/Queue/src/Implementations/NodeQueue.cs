using Queue.src.Interfaces;
using Queue.src.Infrastructure;
using System;
using System.Text;

namespace Queue.src.Implementations
{
    public class NodeQueue : IQueue
    {
        private Node _head;
        private Node _tail;

        public int Count { get; private set; }

        public void Enqueue(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if (_tail == null)
            {
                _tail = node;
                _head = node;
            }
            else
            {
                var tail = _tail;
                tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public object Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Queue is empty");
            }

            var head = _head;
            _head = head.Next;
            head.Next = null;

            if (_head == null)
            {
                _tail = null;
            }

            Count--;
            return head.Value;
        }

        public object Peek()
        {
            if (_head == null)
            {
                throw new Exception("Queue is empty");
            }

            return _head.Value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (_head == null)
            {
                sb.Append("Queue Entrance: empty");
            }
            else
            {
                sb.AppendLine();
                sb.Append("Queue Entrance: ");

                var iterator = _head;
                while (iterator != null)
                {
                    sb.Append(iterator.Value);
                    if (!Equals(iterator, _tail))
                    {
                        sb.Append(", ");
                    }

                    iterator = iterator.Next;
                }
            }

            return sb.ToString();
        }
    }
}