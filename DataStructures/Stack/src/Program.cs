using System;
using Stack.src.Implementations;
using Stack.src.Infrastructure;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackTester.RunReverseString("Hello my name is..", new ArrayStack(), Console.Write);
            Console.WriteLine();
        }
    }
}