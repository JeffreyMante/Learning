using Queue.src.Interfaces;
using System;
using System.Text;

namespace Queue.src.Implementations
{
    public class ArrayQueue : IQueue
    {
        private object[] _array;
        private int _size = 0;
        private int _head = 0;
        private int _tail = 0;

        public int Count { get; private set; }

        public ArrayQueue()
        {
            _array = new object[_size];
        }

        public void Enqueue(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (_tail + 1 > _size)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
                _array[_tail++] = value;
            }
            else
            {
                _array[_tail++] = value;
            }

            Count++;
        }

        public object Dequeue()
        {
            if (_head == _tail)
            {
                throw new Exception("Queue is empty");
            }

            var value = _array[_head++];
            if (_head == _tail)
            {
                _head = 0;
                _tail = 0;
            }

            Count--;
            return value;
        }

        public object Peek()
        {
            if (_head == _tail)
            {
                throw new Exception("Queue is empty");
            }

            return _array[_head];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (_head == _tail)
            {
                sb.Append("Queue Entrance: empty");
            }
            else
            {
                sb.AppendLine();
                sb.Append("Queue Entrance: ");
                for (int i = _head; i < _tail; i++)
                {
                    sb.Append(_array[i]);
                    if (i < _tail - 1)
                    {
                        sb.Append(", ");
                    }
                }
            }

            return sb.ToString();
        }
    }
}