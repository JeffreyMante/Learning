using System;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 3, 3, 23, 43, 1 };
            Print(array);
            MergeSort(ref array);
            Print(array);
        }

        static void MergeSort(ref int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }

            var mid = (int)Math.Ceiling((double)array.Length / 2);
            var left = new int[mid];
            var right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSort(ref left);
            MergeSort(ref right);
            Merge(ref left, ref right, ref array);
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

        static void Merge(ref int[] left, ref int[] right, ref int[] array)
        {
            int i = 0, l = 0, r = 0;
            
            while (l < left.Length && r < right.Length)
            {
                if (left[l] <= right[r])
                {
                    array[i++] = left[l++];
                }
                else
                {
                    array[i++] = right[r++];
                }
            }

            while (l < left.Length)
            {
                array[i++] = left[l++];
            }

            while (r < right.Length)
            {
                array[i++] = right[r++];
            }
        }
    }
}
