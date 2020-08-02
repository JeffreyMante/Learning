using System;
using System.Text;

namespace BytesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter text[:encoding]: ");

                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var inputs = input.Split(':');
                if (inputs.Length <= 0 || inputs.Length > 2)
                {
                    var prevColour = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Invalid input");
                    Console.ForegroundColor = prevColour;
                    Console.WriteLine();
                    continue;
                }

                var name = inputs.Length == 2 ? inputs[1].ToLower() : Encoding.Default.HeaderName;
                var encoding = Encoding.GetEncoding(name);
                var bytes = encoding.GetBytes(inputs[0]);

                Console.WriteLine();
                Console.WriteLine($"Encoding: {encoding.EncodingName}");
                Console.WriteLine($"Text    : {inputs[0]}");
                Console.WriteLine($"Bytes   : {StringifyBytes(bytes)}");
                Console.WriteLine($"Binary  : {StringifyBytesToBinary(bytes)}");
                Console.WriteLine();
            }
        }

        static string StringifyBytes(byte[] byteArray)
        {
            var result = string.Empty;

            if (byteArray != null)
            {
                result += "[ ";

                foreach (var byteVal in byteArray)
                {
                    result += $"{byteVal}, ";
                }

                result = result.Trim(',', ' ');
                result += " ]";
            }

            return result;
        }

        static string StringifyBytesToBinary (byte[] byteArray)
        {
            string result = string.Empty;

            foreach (var byteVal in byteArray)
            {
                result += StringifyByteToBinary(byteVal);
            }

            return result;
        }

        static string StringifyByteToBinary (byte value)
        {
            var val = value;
            var result = string.Empty;
            var log = Math.Log(byte.MaxValue, 2);
            var bitArray = new bool[(int)(Math.Floor(log) + 1)];

            while (val > 0)
            {
                var index = (int)Math.Floor(Math.Log(val, 2));
                val -= (byte)Math.Pow(2, index);
                bitArray[index] = true;
            }

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                result += bitArray[i] ? "1" : "0";
            }

            return result;
        }
    }
}