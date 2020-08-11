using System;
using System.Text;
using Stack.src.Interfaces;

namespace Stack.src.Implementations
{
    /// <summary>
    /// This class represents an array stack implementation.
    /// </summary>
    public sealed class ArrayStack : IStack
    {
        private object[] _array = new object[0];
        private int _size = 0;
        private int _top = 0;

        public int Count => _top;

        public object Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _array[_top];
        }

        public object Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _array[_top--];
        }

        public void Push(object value)
        {
            if (_top + 1 > _array.Length)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
            }

            _array[_top++] = value;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            if (Count == 0)
            {
                stringBuilder.AppendLine("Stack is empty");
            }
            else
            {
                stringBuilder.AppendLine($"Length: {_array.Length}");
                stringBuilder.AppendLine($"Count: {Count}");
                stringBuilder.AppendLine($"Size: {_size}");
                stringBuilder.AppendLine($"Top: {_top}");
                
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();

                for (int i = Count; i > 0; i--)
                {
                    stringBuilder.AppendLine($"[{i - 1}] {_array[i - 1]}");
                }
            }

            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}