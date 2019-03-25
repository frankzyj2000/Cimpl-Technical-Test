using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();

            Console.Write("Type the color you want to display (red, blue, green, white): ... ");
            var color = Console.ReadLine();

            Console.Write("Type the language you want to display (en, fr): ... ");
            var lan = Console.ReadLine();

            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();

            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            var calculator = new Calculator();

            switch (result)
            {
                case "sum":
                    calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2), color, lan);
                    break;
                case "subtract":
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2), color, lan);
                    break;
                case "multiply":
                    calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2), color, lan);
                    break;
                case "divide":
                    calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2), color, lan);
                    break;
            }

            Console.ReadLine();
        }
    }
}
