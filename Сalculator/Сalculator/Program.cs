using System;
using System.Collections;
using System.Threading;

namespace Сalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();  
        }

        #region Calculator
        private static void Calculator()
        {
            string operation = null;
            Console.WriteLine("Select Operation: [+, *, /, %, -, exp, sqrt, module]");

            GetOperation();
            
            string GetOperation()
            {
                
                bool op = true;

                #region Values
               

                int FirstValue()
                {
                    int num1 = 0;
                    try
                    {
                        Console.WriteLine("Input first value:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You didn't choose a number! The value will be taken by default\n");
                    }
                    return num1;
                }

                int SecondValue()
                {
                    int num2 = 0;
                    try
                    {
                        Console.WriteLine("Input second value:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You didn't choose a number! The value will be taken by default\n");
                    }
                    return num2;
                }

                #endregion

                do
                {

                    operation = Convert.ToString(Console.ReadLine());

                    int value;
                    if (string.IsNullOrWhiteSpace(operation) || (int.TryParse(operation, out value) && value >= 1 && value <= int.MaxValue))
                    {
                        Console.WriteLine("Didn't select any operation");
                    }
                    else
                    {
                        op = false;
                    }
                } while (op);

                if ((operation == "exp") || (operation == "EXP") || (operation == "^"))
                {
                    Console.WriteLine("The second number will be the exponent");
                }

                Thread.Sleep(600);

                switch (operation)
                    {
                        case "+":
                        case "addition":
                            Console.WriteLine($"Sum = {Addition(FirstValue(), SecondValue())}");
                            break;
                        case "-":
                        case "subtract":
                            Console.WriteLine($"Difference = {Subtract(FirstValue(), SecondValue())}");
                            break;
                        case "%":
                        case "mod":
                            Console.WriteLine($"Module = {Mod(FirstValue(), SecondValue())}");
                            break;
                        case "*":
                        case "multiply":
                            Console.WriteLine($"Product = {Multiply(FirstValue(), SecondValue())}");
                            break;
                        case "/":
                        case "division":
                        case "div":
                            Console.WriteLine($"Quotient = {Div(FirstValue(), SecondValue())}");;
                            break;
                        case "exp":
                        case "exponent":
                        case "^":
                            Console.WriteLine($"Square of a number = {Exp(FirstValue(), SecondValue())}");
                            break;
                        case "sqrt":
                        case "square root":
                        case "√":
                            Console.WriteLine($"Square root = {Sqrt(FirstValue())}");
                            break;
                        default:
                            Console.WriteLine("You have selected an invalid operation.Try another time");
                            break;
                            
                }
               
                return operation;

            }

            

            #region Operations Methods
            int Addition(int x, int y) 
            {
                int sum = x + y;
                return sum;
            }

            int Subtract(int x, int y)
            {
                int sub = x - y;
                return sub;
            }

            int Multiply(int x, int y)
            {
                int mult = x * y;
                return mult;
            }

            int Div(int x, int y)
            {
                int div = 0;
                if ((x == 0) || (y == 0))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dividing by zero is not allowed");
                    Console.ResetColor();
                }
                else
                {
                    div = x / y;
                }
                
                return div;
            }

            int Mod(int x, int y)
            {
                int mod = 1;
                if ((x == 0) || (y == 0))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Operation failed");
                    Console.ResetColor();
                }
                else
                {
                    mod = x % y;
                }
                
                return mod;
            }

            int Exp(int x, int y)
            {
                int exp = (int)Math.Pow(x, y);
                return exp;
            }

            int Sqrt(int x)
            {
                int sqrt = (int)Math.Sqrt(x);
                return sqrt;
            }
            #endregion
        }
        #endregion 
    }
}
