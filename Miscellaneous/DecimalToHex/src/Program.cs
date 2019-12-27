using System;

namespace DecimalToHex
{
    class Program
    {
        private const string HexValues = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter decimal number: ");
                var input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var number = int.Parse(input);
                var log = Math.Log(Math.Max(1, number), 16);
                var index = (int)Math.Floor(log);
                var hexArray = new string[index + 1];

                for (int i = hexArray.Length - 1; i >= 0; i--)
                {
                    var pow = (int)Math.Floor(Math.Pow(16, i));
                    if (number < pow)
                    {
                        hexArray[i] = "0";
                        continue;
                    }
                    
                    hexArray[i] = HexValues[(number / pow) % 16].ToString();
                    number -= pow * (number / pow);
                }

                Console.WriteLine($"Log: {log}");
                Console.WriteLine($"Hex: {stringifyArray(hexArray)}");
            }
        }

        static string stringifyArray(string[] array)
        {
            var result = string.Empty;

            if (array == null)
            {
                return result;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i].ToString();
            }

            return result;
        }
    }
}