using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_ADV
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Author { get; set; }

        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string iSBN, string title, string[] author, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            string author=string.Join(", ", Author);
            return  $"{ISBN}::{Title}::{author}::{PublicationDate}::{Price}";
        }



    }
}
