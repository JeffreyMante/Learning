using System;
using System.Text;
using Array.src.Infrastructure;
using Array.src.Interfaces;

namespace Array.src.Implementations
{
    public class NodeArray : IArray
    {
        private Node _head;

        public int Count { get; private set; }

        public void Add(object value)
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
                
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }

                iterator.Next = node;
            }

            Count++;
        }
        
        public void AddAtPosition(object value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                Node prevNode = null;
                var iterator = _head;
                var localIndex = 0;

                while (iterator != null && index != localIndex++)
                {
                    prevNode = iterator;
                    iterator = iterator.Next;
                }

                if (prevNode == null)
                {
                    node.Next = iterator;
                    _head = node;
                }
                else
                {
                    node.Next = prevNode.Next;
                    prevNode.Next = node;
                }
            }

            Count++;
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

            Node prevNode = null;
            var iterator = _head;

            while (iterator != null && !Equals(iterator.Value, value))
            {
                prevNode = iterator;
                iterator = iterator.Next;
            }

            if (iterator != null && Equals(iterator.Value, value))
            {
                if (prevNode == null)
                {
                    _head = iterator.Next;
                }
                else
                {
                    prevNode.Next = iterator.Next;
                }

                iterator.Next = null;
                Count--;
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 && index > Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            Node prevNode = null;
            var iterator = _head;
            var localIndex = 0;

            while (iterator != null && index != localIndex++)
            {
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
            
            iterator.Next = null;
            Count--;
        }

        public void Reverse()
        {
            Node iterator = _head;
            Node prevNode = null;

            while (iterator != null)
            {
                var next = iterator.Next;
                iterator.Next = prevNode;
                prevNode = iterator;
                iterator = next;
            }

            _head = prevNode;
        }

        public void Clear()
        {
            _head = null;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            if (_head == null)
            {
                stringBuilder.AppendLine("List is empty");
            }
            else
            {
                stringBuilder.Append("[ ");
                var iterator = _head;

                while (iterator != null)
                {
                    stringBuilder.Append($"{iterator.Value}");
                    if (iterator.Next != null)
                    {
                        stringBuilder.Append(", ");
                    }

                    iterator = iterator.Next;
                }

                stringBuilder.Append(" ]");
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}