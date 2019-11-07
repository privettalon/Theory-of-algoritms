using System.Collections.Generic;


namespace Merge_Sort_C_sharp
{
    class Quick_Sort
    {
        public static int Partition(List<int> arr, int start, int end)
        {
            int pivot = arr[(start + end) / 2];
            while(start<=end)
            {
                while (arr[start]<pivot)
                {
                    start++;
                }
                while(arr[end]>pivot)
                {
                    end--;
                }
                if(start<=end)
                {
                    var temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;

                    start++;
                    end--;
                }
            }
            return start;
        }
        public static void QuickSort(List<int> arr, int start, int end)
        {
            if (start<end)
            {
                var pivot = Partition(arr, start, end);

                QuickSort(arr, start, pivot-1);
                QuickSort(arr, pivot , end);
            }
        }
        public static int findStatistic(List<int> arr,int key)
        {
            int start = 0;
            int end = arr.Count-1 ;
            while(true)
            {
                int pivot = Partition(arr, start, end);
                if(pivot == key)
                {
                    return arr[pivot];
                }
                else if(key<pivot)
                {
                    end = pivot;
                }
                else
                {
                    start = pivot + 1;
                }
            }
        }
    }
}
