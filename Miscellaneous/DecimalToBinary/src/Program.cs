using System;
using System.Linq;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter decimal number: ");
                var input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input)) {
                    break;
                }

                var number = int.Parse(input);
                var log = Math.Log(Math.Max(1, number), 2);
                var exponent = (int)Math.Floor(log);
                var length = Math.Max(1, exponent + 1);
                var bitArray = new bool[(int)length];

                while (number > 0)
                {
                    var index = (int)Math.Floor(Math.Log(Math.Max(1, number), 2));
                    var value = (int)Math.Pow(2, index);
                    bitArray[index] = true;
                    number -= value;
                }

                if (args.Contains("-v") || args.Contains("--verbose"))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Log: {log}");
                    Console.WriteLine($"Exponent: {exponent}");
                    Console.WriteLine($"Length: {length}");
                }

                Console.WriteLine($"Binary: {StringifyBinary(bitArray)}");
                Console.WriteLine();
            }
        }
        
        static string StringifyBinary(bool[] bitArray)
        {
            string output = string.Empty;

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                output += bitArray[i] ? "1" : "0";
            }

            return output;
        }
    }
}