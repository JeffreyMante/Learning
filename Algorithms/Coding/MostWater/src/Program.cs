#region Using Statements

using System;

#endregion

namespace MostWater
{
    /// <summary>
    /// Given n non-negative integers a1, a2,..., an, where each
    /// represents a point at coordinate (i, ai). n vertical lines
    /// are drawn such that the two endpoints of line i is at
    /// (i, ai) and (i, 0). Find two lines, which together
    /// with x-axis forms a container such that the container contains
    /// the most water.
    ///
    /// Note: You may not slant the container and n is at least 2.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(MaxArea(new int[] { 1, 5, 2, 6 }));
            Console.WriteLine();
        }

        static int MaxArea(int[] heights)
        {
            Tuple<int, int> lMax = new Tuple<int, int>(0, 0);
            Tuple<int, int> rMax = new Tuple<int, int>(0, 0);

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > lMax.Item1)
                {
                    lMax = new Tuple<int, int>(heights[i], i);
                }

                var j = (heights.Length - 1) - i;
                if (i >= j) break;

                if (heights[j] > rMax.Item1)
                {
                    rMax = new Tuple<int, int>(heights[j], j);
                }
            }

            var height = Math.Min(lMax.Item1, rMax.Item1);
            var width = rMax.Item2 - lMax.Item2;
            return width * height;
        }
    }
}
