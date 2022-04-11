using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Book
    {
        public string title; // attribute = Book data type
        public string author; // book'un ne oldugunu tanımlayan parcalar
        public int pages; // class attribute

        public Book(string aTitle, string aAuthor, int aPages) // constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}
