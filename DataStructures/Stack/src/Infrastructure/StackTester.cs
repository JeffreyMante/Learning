using System;
using Stack.src.Interfaces;

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

        public static void RunReverseString(string value, IStack stack, Action<string> print)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }

            var charArray = value.ToCharArray();
            foreach(var c in charArray)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                print(stack.Pop().ToString());
            }
        }
    }
}