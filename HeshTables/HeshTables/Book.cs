using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeshTables
{
    class Book
    {
        public string Name { get; set; }

        public int NoP { get; set; }

        public string Author { get; set; }
        
        public Book(string name,  string author, int nop)
        {
            Name = name;
            NoP = nop;
            Author = author;
        }

        public override int GetHashCode()
        {
            return Name.Length + NoP +Author.Length+(int)Name[0];
        }
    }
}
