using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    internal class Book
    {

        public string title;
        public string ISBN;
        public string Author;
        public string PublicationYear;

        public Book(string title , string isbn, string author , string publicationYear)
        {
            this.title = title;
            ISBN = isbn;
            Author = author;
            PublicationYear = publicationYear;
        }



    }
}
