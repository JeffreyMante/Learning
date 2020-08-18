using System;
using Tree.src.Implementations;
using Tree.src.Interfaces;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            ITree tree = new BinaryTree();
            Console.WriteLine(tree.ToString());

            tree.Add(0);
            Console.WriteLine(tree.ToString());

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            Console.WriteLine(tree.ToString());
        }
    }
}
