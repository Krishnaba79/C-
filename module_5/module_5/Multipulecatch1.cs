using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class Multipulcatch1
    {
        static void Main(string[] args)
        {
            // 1. Default throw and multipule catch
            int a, b;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                //string b1 = null;
                //Console.WriteLine(b1.Length);
                int c = a / b;
                Console.WriteLine("Value of C is : "+c);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
