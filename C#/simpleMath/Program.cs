using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A program that prompts for two numbers, print the sum, difference, product, and quotient of those numbers.
namespace simpleMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int castA, castB;
            string a, b;
            Console.Write("Input a number: ");
            a = Console.ReadLine();
            Console.Write("Input a second number: ");
            b = Console.ReadLine();
            castA = int.Parse(a);
            castB = int.Parse(b);
            Console.WriteLine($"The sum of {castA} and {castB} is "+ (castA + castB));
            Console.WriteLine($"The subtraction of {castB} from {castA} is "+ (castA - castB));
            Console.WriteLine($"The product of {castA} and {castB} is " + (castA * castB));
            Console.WriteLine($"The quotient of {castA} and {castB} is "+ (castA / castB));
        }
    }
}