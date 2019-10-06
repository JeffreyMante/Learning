using System;
using DailyProblems.src.Infrastructure;

namespace DailyProblems.src.Solutions
{
    public sealed class Solution0x6 : SolutionBase
    {
        public override void Run()
        {
            PrintLine(Factorial(-4));
            PrintLine(Factorial(-3));
            PrintLine(Factorial(-2));
            PrintLine(Factorial(-1));
            PrintLine(Factorial(0));
            PrintLine(Factorial(1));
            PrintLine(Factorial(2));
            PrintLine(Factorial(3));
            PrintLine(Factorial(4));
        }

        public int Factorial(int n)
        {
            return Factorial(
                Math.Abs(n), 
                n < 0 ? -1 : 1);
        }

        private int Factorial(int n, int r)
        {
            if (n == 0 || n == 1)
            {
                return r;
            }

            return n * Factorial(n - 1, r);
        }
    }
}