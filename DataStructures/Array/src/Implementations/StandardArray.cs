using Array.src.Interfaces;
using System;
using System.Text;

namespace Array.src.Implementations
{
    public class StandardArray : IArray
    {
        private object[] _array = new object[0];
        private int _size = 0;
        private int _tail = 0;

        public int Count => _tail;

        public void Add(object value)
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
            }

          _array[_tail++] = value;
        }

        public void AddAtPosition(object value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (index < 0 || index > _tail)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_tail + 1 > _size)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
            }

            if (++_tail > 1)
            {
                for (int i = _tail - 1; i > 0; i--)
                {
                    _array[i] = _array[i - 1];
                    if (i == index) break;
                }
            }

            _array[index] = value;
        }

        public void Remove(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (_tail == 0)
            {
                throw new Exception("List is empty");
            }

            var found = false;

            for (int i = 0, j = 0; i < _tail - 1; i++, j++)
            {
                if (Equals(_array[i], value) && !found)
                {
                    found = true;
                }

                _array[i] = found ? _array[++j] : _array[j];
            }

            if (found)
            {
                _tail--;
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index > _tail - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_tail == 0)
            {
                throw new Exception("List is empty");
            }

            for (int i = 0, j = 0; i < _tail - 1; i++, j++)
            {
                _array[i] = i == index
                    ? _array[++j]
                    : _array[j];
            }

            _tail--;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            if (Count == 0)
            {
                stringBuilder.AppendLine("List is empty");
            }
            else
            {
                stringBuilder.Append("[ ");

                for (int i = 0; i < Count; i++)
                {
                    stringBuilder.Append($"{_array[i]}");
                    if (i < Count - 1)
                    {
                        stringBuilder.Append(", ");
                    }
                }

                stringBuilder.Append(" ]");
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}