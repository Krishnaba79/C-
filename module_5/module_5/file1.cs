using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class file1
    {
        static void Main(string[] args)
        {
            // divid with zero

            //int a = 10, b = 0;
            //if (b == 0)
            //{
            //    Console.WriteLine("b can't zero");
            //}

            //else 
            //{
            //    int c = a / b;
            //}

            int a = 10, b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("value can't zero");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Continue code");

            Console.ReadLine();
        }
    }
}