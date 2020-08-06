using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialArray = new int[] { 1, 2, 3 };
            PrintArray("Initial: ", initialArray);

            PrintArray("Insert Unordered @ 0: ", InsertUnsorted(initialArray, 0, 15));
            PrintArray("Insert Unordered @ 2: ", InsertUnsorted(initialArray, 2, 50));
            PrintArray("Insert Unordered @ 3: ", InsertUnsorted(initialArray, 3, 84));

            PrintArray("Insert Ordered @ 0: ", InsertSorted(initialArray, 0, 15));
            PrintArray("Insert Ordered @ 2: ", InsertSorted(initialArray, 2, 50));
            PrintArray("Insert Ordered @ 3: ", InsertSorted(initialArray, 3, 84));
        }

        static int[] InsertUnsorted(int[] items, int index, int value)
        {
            var temp = new int[items.Length + 1];

            for(int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }

            temp[temp.Length - 1] = temp[index];
            temp[index] = value;

            return temp; 
        }

        static int[] InsertSorted(int[] items, int index, int value)
        {
            var temp = new int[items.Length + 1];
            var j = 0;

            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = i == index ? value : items[j++];
            }

            return temp; 
        }

        static void PrintArray(string title, int[] items)
        {
            Console.WriteLine();

            if (!string.IsNullOrEmpty(title))
            {
                Console.Write(title);
            }

            if (items != null)
            {
                Console.Write("[");

                for(int i = 0; i < items.Length; i++)
                {
                    Console.Write(items[i]);
                    if (i < items.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.Write("]" + Environment.NewLine);
            }

            Console.WriteLine();
        }
    }
}
