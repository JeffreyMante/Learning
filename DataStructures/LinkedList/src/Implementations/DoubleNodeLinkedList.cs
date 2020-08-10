using LinkedList.src.Infrastructure;
using LinkedList.src.Interfaces;
using System;
using System.Text;

namespace LinkedList.src.Implementations
{
    public sealed class DoubleNodeLinkedList : ILinkedList
    {
        private DoubleNode _head;
        private int _count;

        public int Count => _count;

        public void AddAtStart(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new DoubleNode(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var iterator = _head;
                node.Next = iterator;
                iterator.Previous = node;
                _head = node;
            }

            _count++;
        }

        public void AddAtEnd(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new DoubleNode(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var iterator = _head;

                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }

                node.Previous = iterator;
                iterator.Next = node;
            }

            _count++;
        }

        public void AddAtPosition(int index, object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (index < 0 || index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            var node = new DoubleNode(value);
            var iterator = _head;
            var localIndex = 0;

            while (localIndex < index)
            {
                iterator = iterator.Next;
                localIndex++;
            }

            var prevNode = iterator.Previous;
            if (prevNode == null)
            {
                node.Next = iterator;
                iterator.Previous = node;
                _head = node;
            }
            else
            {
                prevNode.Next = node;
                node.Previous = prevNode;
                node.Next = iterator;
                iterator.Previous = node;
            }

            _count++;
        }

        public void RemoveAtStart()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var iterator = _head;
            _head = iterator.Next;
            _head.Previous = null;
            iterator.Next = null;
            _count--;
        }

        public void RemoveAtEnd()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var iterator = _head;

            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }

            var prevNode = iterator.Previous;
            if (prevNode == null)
            {
                _head = null;
            }
            else
            {
                prevNode.Next = null;
                iterator.Previous = null;
            }

            _count--;
        }

        public void Remove(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var iterator = _head;

            while (iterator != null)
            {
                if (Equals(iterator.Value, value))
                {
                    break;
                }

                iterator = iterator.Next;
            }

            if (iterator == null)
            {
                return;
            }

            var prevNode = iterator.Previous;
            if (prevNode == null)
            {
                _head = iterator.Next;
            }
            else
            {
                prevNode.Next = iterator.Next;
                iterator.Next.Previous = prevNode;
                iterator.Previous = null;
            }

            iterator.Next = null;
            _count--;
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var iterator = _head;
            var localIndex = 0;

            while (localIndex < index)
            {
                iterator = iterator.Next;
                localIndex++;
            }

            var prevNode = iterator.Previous;
            if (prevNode == null)
            {
                _head = iterator.Next;
            }
            else
            {
                prevNode.Next = iterator.Next;
                iterator.Next.Previous = prevNode;
                iterator.Previous = null;
            }

            iterator.Next = null;
            _count--;
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