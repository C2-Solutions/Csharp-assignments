// Group: Michael, Enno, Bryan
using System;
using System.Globalization;
using System.Linq;

namespace CursedCalculator
{
    class Calculator
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Cursed Calculator™!\n" +
                              "This calculator can be a bit finicky, but do not fear! \n" +
                              "Our worker monkeys are working around the clock to keep it from collapsing!\n" +
                              "To help us, please make sure your output value is never below 0! Negative inputs are a-okay!\n");

            while (true)
            {
                Console.Write("Input a value (A): ");
                double valueA = PromptNumber();

                Console.Write("Input a value (B): ");
                double valueB = PromptNumber();

                Console.Write("Select an operation [+ - * / ** //]: ");
                string op = PromptOperator();

                try
                {
                    double result = Operations.Calculate(op, valueA, valueB);

                    ShowResult(op, valueA, valueB, result);

                    Console.WriteLine("\nWas this calculator useful? " +
                                      "If so, please donate any excess bananas " +
                                      "to keep our worker monkeys in good spirits! :)");

                    return;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You can't divide by zero! Please try again.");
                }
                catch (NegativeRootError)
                {
                    Console.WriteLine("You can't use negative values on a square root! Please try again.");
                }
                catch (NegativeOutputError)
                {
                    Console.WriteLine("Output can't be a negative value! Please try again.");
                }
                catch (InvalidOperatorError)
                {
                    Console.WriteLine("Invalid operator! Please try again.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Some kind of error occured! Please try again.");
                }
            }
        }

        private static double PromptNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToDouble(input, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value, please try again: ");
                }
            }
        }

        private static string PromptOperator()
        {
            string[] ValidOperators = new string[] { "+", "-", "*", "/", "**", "//", "^", "√" };

            while (true)
            {
                string op = Console.ReadLine().Trim();
                if (ValidOperators.Any(s => op.Equals(s)))
                {
                    return op;
                }
                else
                {
                    Console.Write("Invalid operator, please try again: ");
                }
            }
        }

        private static void ShowResult(string op, double ValueA, double ValueB, double result)
        {
            string[] SqrtOperators = new string[] { "//", "^", "√" };

            if (result < 0)
            {
                throw new NegativeOutputError();
            }

            if (SqrtOperators.Any(op.Contains))
            {
                Console.WriteLine($"√{ValueA} = {result}");
            }
            else
            {
                Console.WriteLine($"{ValueA} {op} {ValueB} = {result}");
            }
        }
    }

    // Actual arithmatic operations
    public class Operations
    {
        public static double Calculate(string Operator, double ValueA, double ValueB)
        {
#pragma warning disable IDE0066
            switch (Operator)
#pragma warning restore IDE0066
            {
                case "+":
                    return Add(ValueA, ValueB);
                case "-":
                    return Subtract(ValueA, ValueB);
                case "*":
                    return Multiply(ValueA, ValueB);
                case "/":
                    return Divide(ValueA, ValueB);
                case "**":
                    return Pow(ValueA, ValueB);
                case "//" or "^" or "√":
                    return Sqrt(ValueA);
                default:
                    throw new InvalidOperatorError();
            }
        }

        public static double Add(double ValueA, double ValueB)
        {
            return ValueA + ValueB;
        }

        public static double Subtract(double ValueA, double ValueB)
        {
            return ValueA - ValueB;
        }

        public static double Multiply(double ValueA, double ValueB)
        {
            return ValueA * ValueB;
        }
        public static double Divide(double ValueA, double ValueB)
        {
            if (ValueB == 0)
            {
                throw new DivideByZeroException();
            }

            return ValueA / ValueB;
        }
        public static double Pow(double ValueA, double ValueB)
        {
            return Math.Pow(ValueA, ValueB);
        }

        public static double Sqrt(double Value)
        {
            if (Value < 0)
            {
                throw new NegativeRootError();
            }

            return Math.Sqrt(Value);
        }
    }

    // Custom errors
    public class NegativeRootError : ArithmeticException
    {
        public NegativeRootError() { }
    }

    public class NegativeOutputError : ArgumentException
    {
        public NegativeOutputError() { }
    }

    public class InvalidOperatorError : ArgumentException
    {
        public InvalidOperatorError() { }
    }
}
