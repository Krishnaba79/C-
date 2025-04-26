using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class Exceptiontrycatch
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            try
            {
                int total = a / b;
                Console.WriteLine(total);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
            }
            catch (InvalidCastException e)
            {
            }
            finally
            {
                Console.WriteLine("Final line");
            }
            Console.ReadLine();
        }
    }
}