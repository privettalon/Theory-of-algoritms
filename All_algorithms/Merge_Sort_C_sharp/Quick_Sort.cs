using System;
using System.Collections.Generic;


namespace Merge_Sort_C_sharp
{
    class Quick_Sort
    {
        public static void swap (List <int> arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
        public static int Random (int low , int high )
        {
            var rand = new Random();
            int random;

            random = rand.Next(high-low+1)+low;
           
            return random;
        }
        public static int randPartition(List<int> arr, int start, int end)
        {
            int RandomIndex = Random(start, end);
            swap(arr, end, RandomIndex);
            return Partition(arr, start, end);
            
        }
        public static int Partition(List<int> arr, int start, int end)
        {
            Console.WriteLine("Опорний елемент "+ arr[end]+"\n");
            int pivot = arr[end];
            int i = start;
            for (int j = start; j <= end; j++)
            {
                if (arr[j] < pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }
            int swap = arr[i];
            arr[i] = arr[end];
            arr[end] = swap;
            return i;

        }
        public static void QuickSort(List<int> arr, int start, int end)
        {
            if (start<end)
            {
                var pivot = Partition(arr, start, end);

                QuickSort(arr, start, pivot-1);
                QuickSort(arr, pivot+1 , end);
            }
        }
        public static int findStatistic(List<int> arr,int key)
        {
            int start = 0;
            int end = arr.Count-1 ;
            while(true)
            {
                int pivot = randPartition(arr, start, end);
                if(pivot == key)
                {
                    return arr[pivot];
                }
                else if(key<pivot )
                {
                    end = pivot-1;
                }
                else if (key > pivot)
                {
                    start = pivot + 1;
                }
            }
        }
     
    }
}
