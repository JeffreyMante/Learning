using System;

namespace Stack.src.Infrastructure
{
    public sealed class StackTester
    {
        public static void Run(IStack stack, Action<string> print)
        {
            print(stack.ToString());

            stack.Push("Plate 1");
            print(stack.ToString());
            stack.Push("Plate 2");
            print(stack.ToString());
            stack.Push("Plate 3");
            print(stack.ToString());

            print($"Peeking: {stack.Peek()}");
            print($"Popping: {stack.Pop()}");
            print(stack.ToString());

            print($"Peeking: {stack.Peek()}");
            print($"Popping: {stack.Pop()}");
            print(stack.ToString());

            print($"Peeking: {stack.Peek()}");
            print($"Popping: {stack.Pop()}");
            print(stack.ToString());
        }
    }
}