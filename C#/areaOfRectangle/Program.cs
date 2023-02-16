using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfRectangle
{
    internal class Program
    {
        const double feetTometer = 0.09290304;
        
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

        // Calculating the area
        public static int Area(int length, int width)
        {
            return length * width;
        }
        
        // Calculating in Feet
        public static void Feet()
        {
            int length, width;
            length = IntParser("Input a length: ");
            width = IntParser("Input a width: ");
            Console.WriteLine("You inputted the dimensions of {0} length and {1} width", length, width);
            var area = Area(length, width);
            Console.WriteLine("The area is {0} square feet", area);
        }

        // Calculating in Metre
        public static void Metre()
        {
            int length, width;
            length = IntParser("Input a length: ");
            width = IntParser("Input a width: ");
            Console.WriteLine("You inputted the dimensions of {0} length and {1} width", length, width);
            var area = Area(length, width);
            Console.WriteLine("The area is {0} square metre", area);
        }
        static void Main(string[] args)
        {
            string measurement;
            do
            {
                Console.WriteLine("Type your measurement in Foot, 'ft', or Metre, 'm'");
                measurement = Console.ReadLine();
                if (measurement == "ft") Feet();
                else if (measurement == "m") Metre();
                else Console.WriteLine("Please select either foot or metre");
            } while ((String.Compare(measurement, "ft") != 0) || (String.Compare(measurement, "m") != 0));

            /*  int length, width;
              length = IntParser("Input a length: ");
              width = IntParser("Input a width: ");
              Console.WriteLine("You inputted the dimensions of {0} length and {1} width", length, width);
              var area = length * width;
              Console.WriteLine("The area is {0} square feet", area);
              var sqm = area * feetTometer;
              Console.WriteLine("The area is {0} square metres", sqm);*/

        }
    }
}
// TODO: Implement this program as a GUI program that automatically updates the values when any value changes.