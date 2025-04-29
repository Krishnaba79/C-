using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{

    internal class Calc1
    {
        static void Main(String[] args)
        {
        int a, b;
        Console.WriteLine("Making a Calculator Program");
        Console.WriteLine("----------------");

            Console.WriteLine("Enter the value of a");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of a");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter user choice");
            Console.WriteLine("\t1 Addition");
            Console.WriteLine("\t2 Multiplication");
            Console.WriteLine("\t3 Division");
            Console.WriteLine("\t4 Substraction");

            switch (Console.ReadLine())
            {

                case "1":
                    Console.WriteLine($"The addition of the number {a} + {b} =" + (a + b));
                    break;

                case "2":
                    Console.WriteLine($"The Multiplication of the number {a} * {b} =" + (a * b));
                    break;

                case "3":
                    Console.WriteLine($"The Division of the number {a} / {b} =" + (a / b));
                    break;

                case "4":
                    Console.WriteLine($"The Substraction of the number {a} - {b} =" + (a - b));
                    break;


            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
