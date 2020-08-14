using Array.src.Interfaces;
using System;
using System.Text;

namespace Array.src.Implementations
{
    public class StandardArray : IArray
    {
        private object[] _array = new object[0];
        private int _size = 0;

        public int Count { get; private set; }

        public void Add(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (Count + 1 > _size)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
            }

          _array[Count++] = value;
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

            if (Count + 1 > _size)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
            }

            if (++Count > 1 && index <= Count - 1)
            {
                for (int i = Count - 1; i > 0; i--)
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

            if (Count == 0)
            {
                throw new Exception("List is empty");
            }

            var found = false;

            for (int i = 0, j = 0; i < Count - 1; i++, j++)
            {
                if (Equals(_array[i], value) && !found)
                {
                    j++;
                    found = true;
                }

                _array[i] = _array[j];
            }

            if (found)
            {
                Count--;
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count == 0)
            {
                throw new Exception("List is empty");
            }

            for (int i = 0, j = 0; i < Count - 1; i++, j++)
            {
                _array[i] = i == index
                    ? _array[++j]
                    : _array[j];
            }

            Count--;
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