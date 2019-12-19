using System;
using System.Collections.Generic;

namespace HashTables_lab_edition_
{
    class Program
    {
        static void Main(string[] args)
        {
            string chooice;
            string ex1 = "no no no";
            var HashTable = new HashTables<int, string>(1000);
            
            do
            {
                Console.WriteLine("Enter the program: 1 - Collisions and HashMethod Check   2 - HashTables 3 - Exit ");
                chooice = Console.ReadLine();
                switch (chooice)
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            var HashTable1 = new HashTables<int, string>(10000000);
                            var HashTable2 = new HashTables<int, string>(10000000);
                            var HashTable3 = new HashTables<int, string>(10000000);
                            var HashTable4 = new HashTables<int, string>(10000000);
                            var set = new HashSet<int>();
                            var rand = new Random();
                            var list = new List<int>();

                            Console.WriteLine("Enter Method :");
                            Console.WriteLine("1.Random");
                            Console.WriteLine("2.From 1 to 1000");
                            var k = Console.ReadLine();
                            switch (k)
                            {
                                case "1":
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        int random;
                                        do
                                        {
                                            random = rand.Next(1000);
                                        } while (set.Contains(random));
                                        list.Add(random);
                                    }
                                    break;
                                case "2":
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        list.Add(i);
                                    }
                                    break;
                            }

                            for (int i = 0; i < 1000; i++)
                            {
                                HashTable3.Add(list[i], "1", 2);
                                HashTable1.Add(list[i], "1", 3);
                                HashTable2.Add(list[i], "1", 4);
                                HashTable4.Add(list[i], "1", 5);
                            }
                             Console.WriteLine("number of collisions(Division): {0}", HashTable3.GetNumberofCol());
                            Console.WriteLine("number of collisions(Multiplication): {0}", HashTable1.GetNumberofCol());
                            Console.WriteLine("number of collisions(Universal): {0}", HashTable2.GetNumberofCol());
                            Console.WriteLine("number of collisions(Direct Address): {0}", HashTable4.GetNumberofCol());
                           
                        
                            Console.WriteLine("\nDo you want to exit from this program? (1-yes , Other - no)");
                            ex1 = Console.ReadLine();
                        } while (ex1 != "1"); break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Method :");
                            Console.WriteLine("1.Input element");
                            Console.WriteLine("2.Search element");
                            Console.WriteLine("3.Delete element");
                            Console.WriteLine("4.Show element");
                            Console.WriteLine("0.Exit");
                            chooice = Console.ReadLine();
                            if (chooice == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Input key(int):");
                                int key = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Input value :");
                                string value = Console.ReadLine();
                                HashTable.Add(key, value, 1);
                                Console.Clear();
                                Console.WriteLine("Element added to hash table");
                                Console.ReadLine();

                            }
                            if (chooice == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("Input key(int):");
                                int key = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Input value :");
                                string value = Console.ReadLine();
                                Console.Clear();
                                if (HashTable.Search(key, value))
                                {
                                    Console.WriteLine("The item is in the hash table");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Element is not in the hash table");
                                    Console.ReadLine();
                                }
                            }
                            if (chooice=="3")
                            {
                                Console.Clear();
                                Console.WriteLine("Input key(int):");
                                int key = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Input value :");
                                string value = Console.ReadLine();
                                Console.Clear();
                               if( HashTable.Delete(key, value))
                                {
                                    Console.WriteLine("this item has been deleted");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Element is not in the hash table");
                                    Console.ReadLine();
                                }
                            }
                            if (chooice =="4")
                            {
                                Console.Clear();
                                HashTable.ShowTable();
                                Console.ReadLine();
                            }
                        } while (chooice != "0"); break;

                }
            } while (chooice != "3");
        }

    }
}









         