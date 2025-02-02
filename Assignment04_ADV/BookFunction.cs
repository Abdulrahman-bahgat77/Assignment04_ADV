using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_ADV
{
    internal class BookFunction
    {
        public static string GetTitle(Book book)
        {
            if(book is not null)
            {
                return $"Title:{book.Title}";
            }
            return "Not Found";
        }
        public static string GetAuthors(Book book)
        {
            string authors = string.Join(",", book.Author);
           if(book is not null)
            {
                return $"Authors:{authors}";
            }
           return "Not Found";
        }
        public static string GetPrice(Book book)
        {
            if (book is not null)
            {
                return $"Price:{book.Price}";
            }
            return "Not Found";
        }
    }
}
