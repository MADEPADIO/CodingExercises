using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retireCalc
{
    // A program that determines the number of years you have left until retirement and the year you can retire.
    internal class Program
    {//Code (Function) to check if a string is actually a number or not
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
            int age, retire;
            age = IntParser("Input your current age: ");
            retire = IntParser("Input the age you'll like to retire: ");
            int thisYear = DateTime.Now.Year;
            Console.WriteLine("The year is {0}, so the year you will retire is {1}", thisYear, thisYear + (retire - age));

        }
    }
}
