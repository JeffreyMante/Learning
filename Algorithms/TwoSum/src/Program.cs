#region Using Statements

using System;
using System.Linq;
using System.Collections.Generic;

#endregion

namespace TwoSum
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers
    /// such that they add up to the specific target.
    ///
    /// You may assume that each input would have exactly one solution
    /// and you may not use the same element twice.
    ///
    /// Given nums [2, 7, 11, 15], target 9
    /// return [0, 1] 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var results1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            Print(results1);

            var results2 = TwoSum(new int[] { 4, 5, 3, 2, 1, 6, 7 }, 12);

            Print(results2);
        }

        static int[] TwoSum(int[] elements, int target)
        {
            var results = new Dictionary<int, int>();
            var result = new int[2];

            for (int i = 0; i < elements.Length; i++)
            {
                if (results.ContainsKey(target - elements[i]))
                {
                    result[0] = results[target - elements[i]];
                    result[1] = i;
                    break;
                }

                results.Add(elements[i], i);
            }

            return result;
        }

        static void Print(int[] items)
        {
            Console.WriteLine();

            foreach(var item in items)
            {
                Console.WriteLine($"Index [{item}]");
            }

            Console.WriteLine();
        }
    }
}