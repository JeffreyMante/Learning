﻿using System;

namespace Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 3, 3, 23, 43, 1 };
            Print(array);
            InsertionSort(ref array);
            Print(array);
        }

        static void InsertionSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Insert(0, i, array[i], ref array);
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

        static void Insert(int indexStart, int indexEnd, int value, ref int[] array)
        {
            var index = indexEnd;

            while (index > indexStart && array[index - 1] > value)
            {
                array[index] = array[index-- - 1];
            }

            array[index] = value;
        }
    }
}
