using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC470Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, result=0.0;
            string number1String, number2String;
            string operation;
            string quit;
            bool isDouble1 = false, isDouble2 = false, isExit = false, isOperation = false;
            while (isExit == false)
            {
                do
                {
                    Console.Write("Please enter a number: ");
                    number1String = Console.ReadLine();
                    isDouble1 = double.TryParse(number1String, out number1);
                    if (isDouble1 == false)
                        Console.WriteLine("That is not a number. Please try again.");
                } while (isDouble1 == false);
                do
                {
                    Console.Write("Please enter an operation (+,-,*,/): ");
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
                        isOperation = true;
                    else
                    {
                        Console.WriteLine("That is not a valid operation. Please try again.");
                        isOperation = false;
                    }
                } while (isOperation == false) ;
                do
                {
                    Console.Write("Please enter a second number: ");
                    number2String = Console.ReadLine();
                    isDouble2 = double.TryParse(number2String, out number2);
                    if (isDouble2 == false)
                        Console.WriteLine("That is not a number. Please try again.");
                    else if (number2 == 0 && operation == "/")
                        Console.WriteLine("You cannot divide by zero.");
                } while (isDouble2 == false || (number2 == 0 && operation == "/"));
                if (operation.Equals("+"))
                    result = number1 + number2;
                else if (operation.Equals("-"))
                    result = number1 - number2;
                else if (operation.Equals("*"))
                    result = number1 * number2;
                else if (operation.Equals("/"))
                    result = number1 / number2;
                else
                    Console.WriteLine("That is an invaid operation.");
                Console.WriteLine(number1 + " " + operation + " " + number2 + " = " + result);
                Console.Write("Enter q to quit. Enter anything else to make another computation: ");
                quit=Console.ReadLine();
                if (quit == "q")
                    isExit = true;
            }
        }
    }
}
