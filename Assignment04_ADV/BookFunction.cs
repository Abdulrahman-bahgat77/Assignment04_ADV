using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_ADV
{
    internal class BookFunction
    {
         public static string Gettitle(Book B)
        {
            if(B is not null) { 
            return B.Title;
            }
            return "Not Found";
        }
    public static string GetAuthor(Book B)
        {
           string author=string.Join(" ,",B.Author);
            if(B is not null)
            {
                return author;
            }
            return "Not found";
        }
        public static string GetPrice(Book B)
        {
            if(B is not null)
            {
                return $"{B.Price}";
            }
            return "Not Found";
        }
    
    }
}
