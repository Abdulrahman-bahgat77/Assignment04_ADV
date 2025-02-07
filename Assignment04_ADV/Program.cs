using System;
using System.Collections.Generic;

namespace Assignment04_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
             {
                 new Book("1","C",new [] {"Ahmed","Mohammed","Salah"},DateTime.Now,20),
                 new Book("2","C++",new[]{"Abdo","Mano","moo"},DateTime.Now,30),
                 new Book("3","C#",new[]{"Mohammed","Ahmed","Ali"},DateTime.Now,40),
             };

            BookDelegate title = BookFunction.Gettitle;
            BookDelegate author = BookFunction.GetAuthor;
            BookDelegate price = BookFunction.GetPrice;

            LibraryEngine.ProcessBook(books, title);

        }
    }
}
