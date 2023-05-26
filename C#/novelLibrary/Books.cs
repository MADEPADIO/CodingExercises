using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novelLibrary
{
    internal class Books
    {
        public string Title;
        public string Description;
        public string Author;
        public int Pages;
        public Books (string title, string description, string author, int pages)
        {
            Title = title;
            Description = description;
            Author = author;
            Pages = pages;
        }
    }

   
}
