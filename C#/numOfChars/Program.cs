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
            Console.Write("Give me a text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Your text has " + text.Length + " characters");
        }
    }
}
