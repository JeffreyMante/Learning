using System;

namespace Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initail Array: 7, 0, 4, 3, 6, 3, 10, 2 
            int[] array = { 7, 0, 4, 3, 6, 3, 10, 2 };

            Partition(ref array, 3);

            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine);
        }

        static void Partition(ref int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            for (int i = 0; i < right; i++)
            {
                if (array[i + 1] < key)
                {
                    Swap(ref array, left, i + 1);
                    left++;
                }
                else if (array[i + 1] > key)
                {
                    Swap(ref array, i + 1, right);
                    right--;
                    i--;
                }
                else if (array[i] > array[i + 1])
                {
                    Swap(ref array, i, right);
                    right--;
                    i--;
                }
                else
                {
                    left++;
                }
            }
        }

        static void Swap(ref int[] array, int index1, int index2)
        {
            var value1 = array[index1];
            var value2 = array[index2];
            array[index1] = value2;
            array[index2] = value1;
        }
    }
}
