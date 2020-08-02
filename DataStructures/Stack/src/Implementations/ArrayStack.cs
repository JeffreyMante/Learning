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
        private object[] _stackArray = new object[0];
        private int _size = 0;
        private int _top = -1;

        public int Count => _top + 1;

        public object Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _stackArray[_top];
        }

        public object Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _stackArray[_top--];;
        }

        public void Push(object obj)
        {
            if (Count == _stackArray.Length)
            {
                _size = Math.Max(1, _size * 2);
                
                var newArray = new object[_size];
                _stackArray.CopyTo(newArray, 0);
                _stackArray = newArray;
            }

            _stackArray[++_top] = obj;
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
                stringBuilder.AppendLine($"Length: {_stackArray.Length}");
                stringBuilder.AppendLine($"Count: {Count}");
                stringBuilder.AppendLine($"Size: {_size}");
                stringBuilder.AppendLine($"Top: {_top}");
                
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();

                for (int i = Count; i > 0; i--)
                {
                    stringBuilder.AppendLine($"[{i - 1}] {_stackArray[i - 1]}");
                }
            }

            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}