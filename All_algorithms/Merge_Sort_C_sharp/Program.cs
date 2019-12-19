using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace Merge_Sort_C_sharp
{
    class Program
    {
        public static void PrintList(List<int> list, int k)
        {
            if (k == 1) Console.WriteLine("Your array: ");
            if (k == 2) Console.WriteLine("Sorted array is: ");
            foreach (int x in list)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine("\n");
        }
        public static List<int> input_list(int n)
        {
            Console.WriteLine("Input your elements: ");
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(Convert.ToInt32(Console.ReadLine()));

            }
            return result;
        }
        public static List<int> create_list (int n)
        {
          
            var rand = new Random();
            int rnd;
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {

                do
                {
                    rnd = rand.Next(1000000);
                } while (result.Contains(n));
                result.Add(rand.Next(1000000));
               
            }
            return result;
        }
   
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var TextTime = new StreamWriter(@"D:\time.txt");
            var Iter = new StreamWriter(@"D:\Iter.txt");

            string key;
            string input_method;
            string quick_method;
            int exit = 0;
            int q;
            do
            {
                var b = new List<int>();
                var time = new List<int>();
                List<int> unsorted = new List<int>();
                List<int> sorted = new List<int>() ;

                Console.Clear();
                
                Console.Write("Enter number of elements: ");
                var n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                do
                {
                    Console.Write("Enter method: 1- Input element 2- Random ");
                    input_method = Console.ReadLine();
                } while (input_method != "1"&& input_method !="2");
                switch (input_method)
                    {
                    case "1":
                        {
                            unsorted = input_list(n);
                            Console.Clear();
                            PrintList(unsorted, 1);
                        }
                        break;

                    case "2":
                        {
                            unsorted = create_list(n);
                            Console.Clear();
                            
                        } break;
                }

                do
                {
                   
                    Console.WriteLine("\n Enter the method of sorting: ");
                    Console.WriteLine("1. Merge Sort");
                    Console.WriteLine("2. Quick Sort");
                    Console.WriteLine("3. Show k-statistic of your array");
                    Console.WriteLine("4. Counting Sort");
                    Console.WriteLine("5. Radix Sort\n");
                    Console.WriteLine("6. Input a new array");
                    Console.WriteLine("0. Exit");
                    key = Console.ReadLine();

                    switch (key)
                    {
                        case "1":
                            {
                                
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                stopwatch.Restart();
                                stopwatch.Start();
                                sorted = Merge_Sort.MergeSort(sorted);
                                stopwatch.Stop();
                                var ts = stopwatch.Elapsed;
                                Console.WriteLine("Еxecution time : {0} Millisecond", ts);
                                 PrintList(sorted,2);
                                Console.ReadKey();                            }
                            break;
                        case "2":
                            {
                                Console.WriteLine("What do you want?");
                                Console.WriteLine("1.standard Quick Sort ");
                                Console.WriteLine("2.Get a statistic");
                                quick_method = Console.ReadLine();
                                switch (quick_method)
                                {
                                    case "1":
                                        {
                                            Console.Write("Enter the item from which sorting will begin : ");
                                            var k = Convert.ToInt32(Console.ReadLine());
                                            sorted.Clear();
                                            sorted.AddRange(unsorted);
                                            stopwatch.Restart();
                                            stopwatch.Start();
                                            Quick_Sort.QuickSort(sorted, k-1, sorted.Count - 1);
                                            stopwatch.Stop();
                                            var qs = stopwatch.Elapsed;
                                            PrintList(sorted, 2);
                                            Console.WriteLine("Execution time : {0} Millisecond", qs);
                                            Console.ReadKey();
                                        }
                                        break;

                                    //  Console.Write("Enter the item from which sorting will begin : ");
                                    // var k = Convert.ToInt32(Console.ReadLine());
                                    case "2":
                                        {
                                            for (q = 0; q <= n; q += 1000)
                                            {
                                                sorted.Clear();
                                                sorted.AddRange(unsorted);
                                                stopwatch.Restart();
                                                stopwatch.Start();

                                                if (q == n)
                                                {
                                                    Quick_Sort.QuickSort(sorted, 0, q - 1);
                                                }
                                                else
                                                    Quick_Sort.QuickSort(sorted, 0, q);
                                                stopwatch.Stop();
                                                //PrintList(sorted, 2);
                                                var qs = stopwatch.ElapsedMilliseconds;
                                                int milis = Convert.ToInt32(qs);


                                                TextTime.WriteLine(milis);
                                                Iter.WriteLine(q);
                                                // i++;
                                            }
                                            //Console.WriteLine("Execution time : {0} Millisecond", qs);
                                            PrintList(sorted, 2);
                                            Console.ReadKey();
                                            TextTime.Close();
                                            Iter.Close();
                                        }
                                        break;
                                }
                                break;
                            }
                        case "3":
                            {
                               
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                Console.Write("Input k (int): ");
                                var k = Convert.ToInt32(Console.ReadLine());
                                stopwatch.Restart();
                                stopwatch.Start();
                                var stat = Quick_Sort.findStatistic(sorted, k - 1);
                                stopwatch.Stop();
                                Console.WriteLine("Your {0} statistic is {1}", k, stat);
                               var qs = stopwatch.Elapsed;
                                Console.WriteLine("Execution time : {0} Millisecond", qs);
                                Console.ReadKey();  
                            }
                            break;
                        case "4":
                            {
                            
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                stopwatch.Restart();
                                stopwatch.Start();
                                Counting_Sort.countingSort(sorted);
                                stopwatch.Stop();
                                PrintList(sorted,2);
                               var qs = stopwatch.Elapsed;
                                Console.WriteLine("Execution time : {0} Millisecond", qs);
                                Console.ReadKey();
                            }
                            break;
                        case "5":
                            {
                              
                                sorted.Clear();
                                sorted.AddRange(unsorted);
                                stopwatch.Restart();
                                stopwatch.Start();
                                Radix_Sort.radixSort(sorted);
                                stopwatch.Stop();
                                PrintList(sorted,2);
                               var qs = stopwatch.Elapsed;
                                Console.WriteLine("Execution time : {0} Millisecond", qs);
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
