#region Using Statements

using System;

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
            return new int[][] { elements };
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
