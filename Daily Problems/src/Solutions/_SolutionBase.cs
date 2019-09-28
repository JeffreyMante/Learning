using System;
using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblems.src.Solutions
{
    public abstract class SolutionBase
    {
        protected SolutionBase()
        {
            Run();
        }

        public abstract void Run();

        protected virtual void Print(params object[] values)
        {
            foreach(var value in values)
            {
                Write(value);
            }

            Console.WriteLine();
        }

        protected virtual void PrintLine(params object[] values)
        {
            foreach(var value in values)
            {
                Write(value, Environment.NewLine);
            }
        }

        private void Write(object value, string end = " ")
        {
            if (value is IEnumerable && !(value is IEnumerable<char>))
            {
                var items = value as IEnumerable;
                foreach (var item in items)
                {
                    Console.Write(item + end);
                }
            }
            else
            {
                Console.Write(value + end);
            }
        }
    }
}