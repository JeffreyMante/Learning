using System;
using Stack.src.Implementations;
using Stack.src.Infrastructure;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackTester.Run(new ArrayStack(), Console.WriteLine);
        }
    }
}