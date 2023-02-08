using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                Console.Write("Give me a text: ");
                text = Console.ReadLine();
            } while (text == string.Empty) ;
            Console.WriteLine("Your text has " + text.Length + " characters");
        }
    }
}
