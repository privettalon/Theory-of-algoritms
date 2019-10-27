using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_lab_edition_
{
    class Program
    {
        static void Main(string[] args)
        {
            string chooice;
           var HashTable = new HashTables<int, string>(25);
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the Method :");
                Console.WriteLine("1.Input element");
                Console.WriteLine("2.Search element");
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
                    HashTable.Add(key, value);
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
            } while (chooice != "0");
        }
    }
}
