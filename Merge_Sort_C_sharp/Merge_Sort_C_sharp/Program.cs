using System;
using System.Collections.Generic;


namespace Merge_Sort_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Merge = new Merge_Sort();
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Console.Write("Enter number of elements: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Input your elements: ");
            for (int i =0; i<n;i++)
            {
                unsorted.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Clear();

            Console.WriteLine("Your array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine("\nInput any key to start sorting: ");
            Console.ReadLine();
            Console.Clear();

            sorted = Merge.MergeSort(unsorted);

            Console.WriteLine("Sorted array: ");
            foreach(int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            Console.ReadKey();

        }   
    }
}
