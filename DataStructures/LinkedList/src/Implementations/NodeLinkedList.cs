using System;
using System.Text;
using LinkedList.src.Interfaces;
using LinkedList.src.Infrastructure;

namespace LinkedList.src.Implementations
{
    public sealed class NodeLinkedList : ILinkedList
    {
        private Node _head;
        private int _count;

        public int Count => _count;

        public void AddAtStart(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var head = _head;
                _head = node;
                _head.Next = head;
            }

            _count++;
        }

        public void AddAtEnd(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var iterator = _head;
                
                while(iterator.Next != null)
                {
                    iterator = iterator.Next;
                }

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

            var node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var iterator = _head;
                var localIndex = 0;
                Node prevNode = null;

                while(localIndex < index)
                {
                    prevNode = iterator;
                    iterator = iterator.Next;
                    localIndex++;
                }

                node.Next = iterator;
                if (prevNode == null)
                {
                    _head = node;
                }
                else
                {
                    prevNode.Next = node;
                }
            }

            _count++;
        }

        public void RemoveAtStart()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            _head = _head.Next;
            _count--;
        }

        public void RemoveAtEnd()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            var iterator = _head;
            Node prevNode = null;

            while(iterator.Next != null)
            {
                prevNode = iterator;
                iterator = iterator.Next;
            }

            if (prevNode == null)
            {
                _head = null;
            }
            else
            {
                prevNode.Next = null;
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
            Node prevNode = null;

            while (iterator != null)
            {
                if (Equals(iterator.Value, value))
                {
                    break;
                }

                prevNode = iterator;
                iterator = iterator.Next;
            }

            if (prevNode == null)
            {
                _head = iterator.Next;
            }
            else
            {
                prevNode.Next = iterator.Next;
            }

            _count--;
        }

        public void RemoveAtPosition(int index)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            if (index < 0 || index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            var iterator = _head;
            var localIndex = 0;
            Node prevNode = null;

            while (localIndex < index)
            {
                prevNode = iterator;
                iterator = iterator.Next;
                localIndex++;
            }

            if (prevNode == null)
            {
                _head = null;
            }
            else
            {
                prevNode.Next = iterator.Next;
            }

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