using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_ADV
{
    public delegate string BookDelegate(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBook(List <Book> book ,BookDelegate Fptr )
        {
            foreach(Book b in book )
            {
                Console.WriteLine(Fptr(b));
            }
        }

        public static void ProcessBook(List<Book> book, Func<Book,string> Fptr)
        {
            foreach (Book b in book)
            {
                Console.WriteLine(Fptr(b));
            }
        }
    }
}
