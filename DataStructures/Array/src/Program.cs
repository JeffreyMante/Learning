using System;
using Array.src.Interfaces;
using Array.src.Infrastructure;
using Array.src.Implementations;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            IArray array = new StandardArray();
            Console.WriteLine(array.ToString());

            array.AddAtPosition(1, 0);
            Console.WriteLine(array.ToString());

            array.AddAtPosition(2, 0);
            Console.WriteLine(array.ToString());

            array.AddAtPosition(3, 0);
            Console.WriteLine(array.ToString());

            array.AddAtPosition(4, 1);
            Console.WriteLine(array.ToString());

            array.AddAtPosition(5, 3);
            Console.WriteLine(array.ToString());

            /*array.Remove(1);
            Console.WriteLine(array.ToString());

            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(6);
            Console.WriteLine(array.ToString());

            array.Remove(1);
            Console.WriteLine(array.ToString());

            array.Remove(4);
            Console.WriteLine(array.ToString());*/
        }
    }
}
