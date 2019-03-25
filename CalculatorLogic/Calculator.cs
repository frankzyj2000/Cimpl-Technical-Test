using System;

namespace CalculatorLogic
{
    public class Calculator
    {
        private ConsoleColor Color = ConsoleColor.White;

        private String CalculatorLanguage = "EN";

        public void SetLanguage(string lan)
        {
            switch (lan.ToUpper())
            {
                case "EN":                    
                case "FR":
                    this.CalculatorLanguage = lan;
                    break;
                default:
                    this.CalculatorLanguage = "EN";
                    break;
            }
        }

        public string GetOutputForLanugage()
        {
            switch (this.CalculatorLanguage.ToUpper())
            {
                case "EN":
                    return "The result is: ";
                case "FR":
                    return "Le résultat est: ";
                default:
                    return "The result is: ";
            }
        }


        public void SetColor(string color)
        {
            switch (color)
            {
                case "red":
                    this.Color = ConsoleColor.Red;
                    return;
                case "blue":
                    this.Color = ConsoleColor.Blue;
                    return;
                case "green":
                    this.Color = ConsoleColor.Green;
                    return;
                case "white":
                    this.Color = ConsoleColor.White;
                    return;
                default:
                    this.Color = ConsoleColor.White;
                    return;
            }
        }
        
        public string CommCalculatorJob(string color, string lan)
        {
            SetColor(color);
            SetLanguage(lan);
            return GetOutputForLanugage();
        }

        public double Sum(double a, double b, string color, string lan)
        {
            var x = a + b;
            string intro = CommCalculatorJob(color, lan);
            Console.ForegroundColor = this.Color;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(intro + " " + x.ToString());
            return x;
        }

        public double Subtract(double a, double b, string color, string lan)
        {
            var x = a - b;
            string intro = CommCalculatorJob(color, lan);
            Console.ForegroundColor = this.Color;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(intro + " " + x.ToString());
            return x;
        }

        public double Multiply(double a, double b, string color, string lan)
        {
            var x = a * b;
            string intro = CommCalculatorJob(color, lan);
            Console.ForegroundColor = this.Color;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(intro + " " + x.ToString());
            return x;
        }

        public double? Divide(double a, double b, string color, string lan)
        {
            double? x = null;
            if (b != 0)
            {
                x = a / b;
            }
            string intro = CommCalculatorJob(color, lan);
            Console.ForegroundColor = this.Color;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (x == null)
            {
                if (lan.ToUpper() == "FR")
                {
                    Console.WriteLine("Erreur: le dividende ne peut être nul!");
                }
                else
                {
                    Console.WriteLine("Error: the dividend can't be zero!");
                }
            }
            else
            {
                Console.WriteLine(intro + " " + x.ToString());
            }            
            return x;
        }
    }
}
