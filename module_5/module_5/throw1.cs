using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class throw1
    {
        static void Main(string[] args)
        {
            // 1. Default throw and Default catch

            //int a = 10, v = 0, c;
            //c = a / v; // default throw
            //Console.WriteLine(c);


            // 2. Default throw and catch by try and catch
            //try
            //{
            //    int a = 10, v = 0, c;
            //    c = a / v; // default throw
            //    Console.WriteLine(c);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // 3. Our throw and default catch

            //Console.WriteLine("Enter Your Age : ");
            //int age = Convert.ToInt16(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("You are eligble for vote");
            //}
            //else 
            //{
            //    throw new Exception("You are note eligble");
            //}


            // 3. Our throw and our catch

            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt16(Console.ReadLine());

            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are eligble for vote");
                }
                else
                {
                    throw new Exception("You are note eligble");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}