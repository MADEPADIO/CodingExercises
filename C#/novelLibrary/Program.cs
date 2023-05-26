using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novelLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Harry Porter", "About Magic in the wizarding world", "JK Rowling", 400);
            Books book2 = new Books("Matthias of RedWall", "Redwall Series", "Brian Jacques", 500);

            Console.WriteLine("The name of the first book is " + book1.Title + ", written by " + book1.Author + ", and it is about " + book1.Pages + " pages.");
            Console.WriteLine("The name of the second book is " + book2.Title + ", written by " + book2.Author + ", and it is about " + book2.Pages + " pages.");
            Console.ReadLine();
        }
    }
}
