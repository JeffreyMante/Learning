using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 3, 3, 23, 43, 1 };
            Print(array);
            BubbleSort(ref array);
            Print(array);
        }

        static void BubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1, ref array);
                    }
                }
            }
        }
        
        static void Print(int[] array)
        {
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(Environment.NewLine);
                }
            }

            Console.WriteLine();
        }

        static void Swap(int index1, int index2, ref int[] array)
        {
            var val1 = array[index1];
            var val2 = array[index2];
            array[index1] = val2;
            array[index2] = val1;
        }
    }
}
