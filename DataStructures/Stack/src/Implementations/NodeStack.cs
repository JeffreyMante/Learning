using System;
using System.Text;
using Stack.src.Infrastructure;
using Stack.src.Interfaces;

namespace Stack.src.Implementations
{
    public class NodeStack : IStack
    {
        private Node _head;
        private int _count;

        public int Count => _count;

        public object Peek()
        {
            if (_head == null)
            {
                throw new Exception("Stack is empty");
            }

            return _head.Value;
        }

        public object Pop()
        {
            if (_head == null)
            {
                throw new Exception("Stack is empty");
            }

            var head = _head;
            _head = _head.Next;
            head.Next = null;

            _count--;
            return head.Value;
        }

        public void Push(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var node = new Node(value);

            if(_head == null)
            {
                _head = node;
            }
            else
            {
                var head = _head;
                node.Next = head;
                _head = node;
            }

            _count ++;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            if (_head == null)
            {
                stringBuilder.AppendLine("Stack is empty");
            }
            else
            {
                stringBuilder.AppendLine($"Count: {Count}");
                
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();

                var iterator = _head;
                int i = 0;

                while (iterator != null)
                {
                    stringBuilder.AppendLine($"[{i++}] {iterator.Value}");
                    iterator = iterator.Next;
                }
            }

            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}