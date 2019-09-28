namespace DailyCodingProblems.src.Solutions
{
    /// <Description>
    /// Given an array of integers, find the first missing positive integer in linear time and 
    /// constant space. In other words, find the lowest positive integer that does not exist in 
    /// the array. The array can contain duplicates and negative numbers as well.
    ///
    /// For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
    ///
    /// You can modify the input array in-place.
    /// </Description>
    public sealed class Solution0x4 : SolutionBase
    {
        public Solution0x4() : base() { }

        public override void Run()
        {
            var fp1 = FirstMissingPositiveInt(new int[] { 3, 4, -1, 1 });
            if (fp1 == 2)
            {
                PrintLine("Found first missing positive int 2");
            }

            var fp2 = FirstMissingPositiveInt(new int[] { 1, 2, 0 });
            if (fp2 == 3)
            {
                PrintLine("Found first missing positive int 3");
            }

            var fp3 = FirstMissingPositiveInt(new int[] { 0 });
            if (fp3 == 1)
            {
                PrintLine("Found first missing positive int 1");
            }

            var fp4 = FirstMissingPositiveInt(new int[] { -1 });
            if (fp4 == 1)
            {
                PrintLine("Found first missing positive int 1");
            }

            var fp5 = FirstMissingPositiveInt(new int[] { });
            if (fp5 == 1)
            {
                PrintLine("Found first missing positive int 1");
            }
        }

        private int FirstMissingPositiveInt(int[] list)
        {
            int value = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > 0 && list[i] > value && list[i] <= value + 1)
                {
                    value = list[i];
                }
            }

            return value + 1;
        }
    }
}