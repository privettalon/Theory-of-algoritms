using System.Collections.Generic;
using System.Linq;

namespace Merge_Sort_C_sharp
{
    class Counting_Sort
    {
       public static void countingSort(List<int> arr)
       {
            int min = arr.Min();
            int max = arr.Max();

            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int [arr.Count];

            for(int i = 0;i<arr.Count;i++)
            {
                count[arr[i] - min]++;
            }


            for(int i=1;i<count.Length;i++)
            {
                count[i] += count[i - 1];
            }


            for(int i = arr.Count-1;i>=0;i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }


            for(int i =0;i<arr.Count;i++)
            {
                arr[i] = output[i];
            }
       }
    }
    class Radix_Sort
    {
        public static void countSotrt(List<int> arr, int exp)
        {
            var n = arr.Count;

            int[] output = new int[n];           
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }


            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }


            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }


            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }


            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
        public static void radixSort(List<int> arr)
        {
            int max = arr.Max();
            
            for(int exp = 1;max/exp>0;exp*=10)
            {
                countSotrt(arr, exp); ;
            }
        }
    }
}
