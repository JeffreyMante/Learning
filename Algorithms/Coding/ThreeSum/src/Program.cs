#region Using Statements

using System;
using System.Collections.Generic;

#endregion

namespace ThreeSum
{
    /// <summary>
    /// Given and array S of n integers, are there elements
    /// a, b, c in S such that a + b + c = 0? Find all
    /// unique triplets in the array which gives the sum
    /// of zero.
    ///
    /// Note: The solution set must not contain duplicate
    /// triplets
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Print(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 } ));
        }

        static int[][] ThreeSum(int[] elements)
        {
            var results = new List<int[]>();
            int a = 0, b = 0, c = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                a = elements[i];
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (j == i) continue;
                    
                    b = elements[j];
                    c = elements[j + 1];

                    if (a + b + c == 0)
                    {
                        results.Add(new int[] { a, b, c });
                    }
                }
            }

            return results.ToArray();
        }

        static void Print(int[][] results)
        {
            Console.Write(Environment.NewLine + "[");

            if (results.Length > 0)
            {
                Console.WriteLine(Environment.NewLine);

                foreach (var result in results)
                {
                    Console.Write("  [");

                    var output = string.Empty;
                    foreach(var item in result)
                    {
                        output += $" {item},";
                    }
                    
                    output = output.Trim(',');
                    if (result.Length > 0)
                    {
                        output += " ";
                    }

                    Console.Write(output);
                    Console.WriteLine("]");
                }

                Console.WriteLine();
            }

            Console.WriteLine("]" + Environment.NewLine);
        }
    }
}
