using System.Collections.Generic;
using System.Linq;
using System;


namespace Merge_Sort_C_sharp
{
    class Merge_Sort
    {
        public static  List<int> MergeSort(List<int> unsorted)
        {
            Program.PrintList(unsorted, 1);
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
         
            right = MergeSort(right);


            return Merge(left, right);


        }
        public static  List<int> Merge (List<int> left , List <int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First<int>() < right.First<int>())
                    {
                        result.Add(left.First<int>());
                        left.Remove(left.First<int>());
                    }
                    else
                    {
                        result.Add(right.First<int>());
                        right.Remove(right.First<int>());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First<int>());
                    left.Remove(left.First<int>());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First<int>());
                    right.Remove(right.First<int>());
                }
            }
           Program.PrintList(result, 2);
            return result;
        }
    }
}

