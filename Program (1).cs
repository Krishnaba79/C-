using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int a; int b;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            a = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            b = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtraction");
            Console.WriteLine("\t3 - Multiplication");
            Console.WriteLine("\t4 - Division");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result: {a} + {b} = " + (a + b));
                    break;
                case "2":
                    Console.WriteLine($"Your result: {a} - {b} = " + (a - b));
                    break;
                case "3":
                    Console.WriteLine($"Your result: {a} * {b} = " + (a * b));
                    break;
                case "4":
                    Console.WriteLine($"Your result: {a} / {b} = " + (a / b));

                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
