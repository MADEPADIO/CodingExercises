using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaParty
{
    internal class Program
    {
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
                if (!IsAllDigits(s)) Console.WriteLine("Please input a number");
                else number = int.Parse(s);
            } while (!IsAllDigits(s));
            return number;
        }

        //Function that accepts non negative integers
        public static uint PosInt(uint num)
        {
            //int accept;
            uint digit = 0;

            do
            {
                num = (uint)IntParser("Please input a positive number");
                if (num < 0)
                {
                    Console.WriteLine("please input a non negative number");
                }
                else digit = num;
            } while (num < 0);
            return digit;
        }


        static void Main(string[] args)
        {
            int slices, people, pizza;
            people = (int)PosInt((uint)IntParser("How many people? "));
            pizza = (int)PosInt((uint)IntParser("How many pizzas? "));
            slices = (int)PosInt((uint)IntParser("How many slices should be in a pizza? "));
           /* var piece = slices * pizza;
            var shares = piece / people;
            Console.WriteLine("Each person will have {0} slices of pizza", shares);*/
        }
    }
}