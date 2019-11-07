using System;
using System.Collections.Generic;


namespace Merge_Sort_C_sharp
{
    class Program
    { 
        public static List<int> create_list (int n)
        {
            Console.WriteLine("Input your elements: ");
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(Convert.ToInt32(Console.ReadLine()));

            }
            return result;
        }
        public static void PrintList (List<int> list , int k)
        {
          if(k==1)  Console.WriteLine("Your array: ");
          if(k==2) Console.WriteLine("Sorted array is: ");
            foreach (int x in list)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            string key;
            int exit = 0;

            do
            { 
                
                List<int> unsorted = new List<int>();
                List<int> sorted = new List<int>() ;

                Console.Clear();
                Console.Write("Enter number of elements: ");
                var n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                unsorted = create_list(n);
               
              
                

                do
                {
                    Console.Clear();
                    PrintList(unsorted,1);

                    Console.WriteLine("\n Enter the method of sorting: ");
                    Console.WriteLine("1. Merge Sort");
                    Console.WriteLine("2. Quick Sort");
                    Console.WriteLine("3. Show k-statistic of your array");
                    Console.WriteLine("4. Counting Sort");
                    Console.WriteLine("5. Radix Sort\n");
                    Console.WriteLine("5. Input a new array");
                    Console.WriteLine("0. Exit");
                    key = Console.ReadLine();

                    switch (key)
                    {
                        case "1":
                            {
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                sorted = Merge_Sort.MergeSort(sorted);
                                PrintList(sorted,2);
                                Console.ReadKey();                            }
                            break;
                        case "2":
                            {
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                Quick_Sort.QuickSort(sorted, 0, sorted.Count - 1);
                                PrintList(sorted, 2);
                                Console.ReadKey();
                            }break;
                        case "3":
                            { 
                                    sorted.Clear();
                                    sorted.AddRange(unsorted);
                                    Console.Write("Input k (int): ");
                                    var k = Convert.ToInt32(Console.ReadLine());
                                    var stat = Quick_Sort.findStatistic(sorted, k - 1);
                                    Console.WriteLine("Your {0} statistic is {1}", k, stat);
                                    Console.ReadKey();  
                            }
                            break;
                        case "4":
                            {
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                Counting_Sort.countingSort(sorted);
                                PrintList(sorted,2);
                                Console.ReadKey();
                            }
                            break;
                        case "5":
                            {
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                Radix_Sort.radixSort(sorted);
                                PrintList(sorted,2);
                                Console.ReadKey();
                            }
                            break;
                        case "6":
                            {

                            }
                            break;
                        case "0":
                            {
                                key = "6";
                                exit = 1;
                            }break;


                    }
                } while (key != "6");
            } while ( exit == 0);


        }   
    }
}
