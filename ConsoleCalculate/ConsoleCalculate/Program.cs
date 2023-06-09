using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string action;
            double firstValue, secondValue, result;
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Enter the first number: ");
                    firstValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondValue = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter numbers, not letters.");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Enter the operation to be performed (+, -, /, *): ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        {
                            result = firstValue + secondValue;
                            Console.WriteLine(result);
                            break;
                        }
                    case "-":
                        {
                            result = firstValue - secondValue;
                            Console.WriteLine(result);
                            break;
                        }
                    case "/":
                        {
                            if (firstValue == 0)
                                Console.WriteLine(0);
                            else if (secondValue == 0)
                                Console.WriteLine(0);
                            else
                            {
                                result = firstValue / secondValue;
                                Console.WriteLine(result);
                            }
                            break;
                        }
                    case "*":
                        {
                            result = firstValue * secondValue;
                            Console.WriteLine(result);
                            break;
                        }
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
