using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class Formet_e
    {
        static void Main(string[] args)
        {
            try
            {
                int s;
                s = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(s);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                //Console.WriteLine("This is finally block");

                int x = 10;
                x++;
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}