using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

//A program that prompts for two numbers, print the sum, difference, product, and quotient of those numbers.
namespace simpleMath
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

       /* public static int MathOps(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of {firstNum} and {secondNum} is " + (firstNum + secondNum));
            Console.WriteLine($"The subtraction of {secondNum} from {firstNum} is " + (firstNum - secondNum));
            Console.WriteLine($"The product of {firstNum} and {secondNum} is " + (firstNum * secondNum));
            Console.WriteLine($"The quotient of {firstNum} and {secondNum} is " + (firstNum / secondNum));
            return MathOps(firstNum,secondNum);
        }*/

        static void Main(string[] args)
        {
            int firstNum, secondNum;
            do
            {
                firstNum = IntParser("Input a first number: ");
                secondNum = IntParser("Input a second number: ");
                if (firstNum < 0 || secondNum < 0)
                {
                    Console.WriteLine("Input a non negative number");
                }
            } while (firstNum < 0 || secondNum < 0);
            Console.WriteLine($"The sum of {firstNum} and {secondNum} is " + (firstNum + secondNum));
            Console.WriteLine($"The subtraction of {secondNum} from {firstNum} is " + (firstNum - secondNum));
            Console.WriteLine($"The product of {firstNum} and {secondNum} is " + (firstNum * secondNum));
            Console.WriteLine($"The quotient of {firstNum} and {secondNum} is " + (firstNum / secondNum));
        }
    }
}
//TODO: Implement this program as a GUI program that automatically updates the values when any value changes.