using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace printingQuotes
{
    // A Pragram that prompts user for a quote and its author, then displays it as a complete sentence using a quotation mark for the quote.
    internal class Program
    {
        static void Main(string[] args)
        {
            string quote, author;
            Console.Write("What is the quote? ");
            quote= Console.ReadLine();
            Console.Write("Who is the author? ");
            author= Console.ReadLine();
            Console.WriteLine(author + " said, " + "\"" + quote + ".\"");
        }
    }
}
/*TODO: Modify this program so that
instead of prompting for quotes from the user, you create
a structure that holds quotes and their associated
attributions and then display all of the quotes using the
format in the example. An array of maps would be a
good choice.*/
