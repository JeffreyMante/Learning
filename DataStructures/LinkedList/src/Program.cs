using System;
using LinkedList.src.Interfaces;
using LinkedList.src.Implementations;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList list = new NodeLinkedList();
            Console.WriteLine(list.ToString());

            list.AddAtEnd(1);
            list.AddAtEnd(1);
            list.AddAtEnd(2);
            list.AddAtEnd(3);
            list.AddAtEnd(3);
            Console.WriteLine(list.ToString());

            list.Remove(1);
            Console.WriteLine(list.ToString());

            list.Remove(3);
            Console.WriteLine(list.ToString());

            list.AddAtStart(4);
            Console.WriteLine(list.ToString());

            list.AddAtStart(5);
            Console.WriteLine(list.ToString());

            list.AddAtPosition(0, 6);
            Console.WriteLine(list.ToString());

            list.AddAtPosition(3, 7);
            Console.WriteLine(list.ToString());

            list.RemoveAtStart();
            Console.WriteLine(list.ToString());

            list.RemoveAtEnd();
            Console.WriteLine(list.ToString());

            list.RemoveAtPosition(2);
            Console.WriteLine(list.ToString());
        }
    }
}