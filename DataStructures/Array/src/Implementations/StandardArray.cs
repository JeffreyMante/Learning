using Array.src.Interfaces;
using System;
using System.Text;

namespace Array.src.Implementations
{
    public class StandardArray : IArray
    {
        private object[] _array = new object[0];
        private int _size = 0;
        private int _index = 0;

        public int Count => _index;

        public void Add(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (_index + 1 > _size)
            {
                _size = Math.Max(1, _size * 2);
                var temp = new object[_size];
                _array.CopyTo(temp, 0);
                _array = temp;
            }

          _array[_index++] = value;
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

            for (int i = 0, j = 0; i < _index; i++)
            {
                if (Equals(_array[i], value))
                {
                    if (_index == 1)
                    {
                        break;
                    }

                    j++;
                }

                if (j < _index)
                {
                    _array[i] = _array[j++];
                }
            }

            _index--;
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