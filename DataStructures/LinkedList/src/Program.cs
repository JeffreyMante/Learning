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

            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            Console.WriteLine(list.ToString());

            list.Remove(1);
            Console.WriteLine(list.ToString());

            list.Remove(3);
            Console.WriteLine(list.ToString());

            list.Remove(1);
            Console.WriteLine(list.ToString());

            list.Remove(2);
            Console.WriteLine(list.ToString());
        }
    }
}