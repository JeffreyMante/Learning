using DailyProblems.src.Infrastructure;

namespace DailyProblems.src.Solutions
{
    /// <Description>
    ///  Given an array of integers, return a new array such that each element 
    ///  at index i of the new array is the product of all the numbers in the 
    ///  original array except the one at i.
    ///  
    ///  For example, if our input was [1, 2, 3, 4, 5], the expected output would be 
    ///  [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would 
    ///  be [2, 3, 6].
    ///
    ///  Follow-up: what if you can't use division?
    /// </Desciption>
    public sealed class Solution0x2 : SolutionBase
    {
        public Solution0x2() : base() { }

        public override void Run()
        {
            Print(CalculateProducts(new int[] { 1, 2, 3, 4, 5 }));
            Print(CalculateProducts(new int[] { 3, 2, 1 }));
        }

        private int[] CalculateProducts(int[] list)
        {
            int[] results = new int[list.Length];
            int total = 1;

            for (int i = 0; i < list.Length; i++)
            {
                total *= list[i];
            }

            for (int i = 0; i < list.Length; i++)
            {
                results[i] = total / list[i];
            }

            return results;
        }
    }
}