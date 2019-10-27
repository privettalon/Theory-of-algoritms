using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeshTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new MyHeshTables<Book>(100);
            var The_best_book = new Book("ll", "kk", 24);
            HashTable.Add(The_best_book);
            HashTable.Add(new Book("23", "we", 24));
            Console.WriteLine(HashTable.Search(The_best_book));
         Console.ReadLine();
        }
    }
}
