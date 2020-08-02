using System;
using DailyProblems.src.Infrastructure;

namespace DailyProblems.src.Solutions
{
    /// <Description>
    /// cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns 
    /// the first and last element of that pair. For example, 
    /// car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
    ///
    /// Given this implementation of cons:
    ///
    /// def cons(a, b):
    ///     def pair(f):
    ///        return f(a, b)
    ///    return pair
    ///
    /// Implement car and cdr.
    /// </Description>
    public sealed class Solution0x5 : SolutionBase
    {
        public Solution0x5() : base() { }

        public override void Run()
        {
            if (Car(Cons(3, 4)) == 3)
            {
                PrintLine("Found left");
            }

            if (Cdr(Cons(3, 4)) == 4)
            {
                PrintLine("Found right");
            }
        }

        public int Car(Tuple<int, int> pair)
        {
            return pair.Item1;
        }

        private int Cdr(Tuple<int, int> pair)
        {
            return pair.Item2;
        }

        private Tuple<int, int> Cons(int a, int b)
        {
            return new Tuple<int, int>(a, b);
        }
    }
}