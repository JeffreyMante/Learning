using System.Collections.Generic;

namespace DailyCodingProblems.src.Solutions
{
    /// <Description>
    /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
    /// For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
    /// Bonus: Can you do this in one pass?
    /// </Description>
    public sealed class Solution0x1 : SolutionBase
    {
        public Solution0x1() : base() { }

        public override void Run()
        {
            if (ContainsSumPair(new int[] { 10, 15, 3, 7 }, 17))
            {
                PrintLine("Contains sum pair!");
            }
            else
            {
                PrintLine("Does not contain sum pair!");
            }
        }

        private bool ContainsSumPair(int[] list, int total)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();
            
            for (int i = 0; i < list.Length; i++)
            {
                int result = total - list[i];
                if (results.ContainsKey(result))
                {
                    return true;
                }

                results.Add(list[i], i);
            }

            return false;
        }
    }
}