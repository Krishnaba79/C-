using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        string operation;

        Console.WriteLine("Welcome to the Console Calculator!");

        // Get first number
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Get operation
        Console.Write("Enter an operation (+, -, *, /): ");
        operation = Console.ReadLine();

        // Get second number
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform calculation based on operation
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation.");
                break;
        }

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}