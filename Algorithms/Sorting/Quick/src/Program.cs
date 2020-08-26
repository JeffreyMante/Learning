using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 3, 3, 23, 43, 1 };
            Print(array);
            QuickSort(ref array);
            Print(array);
        }

        static void QuickSort(ref int[] array)
        {
            Partition(0, array.Length - 1, ref array);
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

        static void Partition(int indexStart, int indexEnd, ref int[] array)
        {
            if ((indexEnd - indexStart) + 1 < 2)
            {
                return;
            }

            var key = array[new Random().Next(indexStart, indexEnd)];
            int i = indexStart, l = indexStart, r = indexEnd;

            while (i <= r)
            {
                if (array[i] < key)
                {
                    Swap(i, l++, ref array);
                    i = l;
                }
                else if (array[i] > key)
                {
                    Swap(i, r--, ref array);
                    i = l;
                }
                else
                {
                    i++;
                }
            }

            Partition(0, l - 1, ref array);
            Partition(r + 1, indexEnd, ref array);
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