using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfRectangle
{
    internal class Program
    {
        const double feetConst = 0.09290304;
        
        //Code (Function) to check if a string is actually a number or not
        public static bool IsAllDigits(string raw)
        {
            //Get rid of any benign character at either end, if there's nothing left, you don't have a number.
            string s = raw.Trim(); //ignores the whitespace on either side.
            if (s.Length == 0) return false;
            for (int index = 0; index < s.Length; index++)
            {
                //-ve signs are ok, so go to the next character.
                if (s[index] == '-' && index == 0) continue;
                // A nondigit indicates that the string probably isn't a number.
                if (Char.IsDigit(s[index]) == false) return false;
            }
            //No nondigits found.
            return true;
        }

        //Code that converts the string to an int.
        public static int IntParser(string prompt)
        {
            string s;
            int number = 0;
            do
            {
                Console.Write(prompt);
                s = Console.ReadLine();
                if (!IsAllDigits(s))
                {
                    Console.WriteLine("Please input a number");
                }
                else
                {
                    number = int.Parse(s);
                }
            } while (!IsAllDigits(s));
            return number;
        }

        static void Main(string[] args)
        {
            int length, width;
            length = IntParser("Input a length: ");
            width = IntParser("Input a width: ");
            Console.WriteLine("You inputted the dimensions of {0} length and {1} width", length, width);
            var area = length * width;
            Console.WriteLine("The area is {0} square feet", area);
            var sqm = area * feetConst;
            Console.WriteLine("The area is {0} square metres", sqm);
        }
    }
}
