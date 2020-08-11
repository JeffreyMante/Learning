using System;
using Queue.src.Interfaces;
using Queue.src.Infrastructure;
using Queue.src.Implementations;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue queue = new NodeQueue();
            Console.WriteLine(queue.ToString());

            queue.Enqueue(1);
            Console.WriteLine(queue.ToString());

            queue.Enqueue(2);
            Console.WriteLine(queue.ToString());

            queue.Enqueue(3);
            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            Console.WriteLine();
            Console.WriteLine(queue.ToString());
        }
    }
}
