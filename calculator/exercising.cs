using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Basic Calculator!");

        while (true)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string continueCalculation = Console.ReadLine();
            if (continueCalculation.ToLower() != "yes")
            {
                break;
            }
        }
    }
}
