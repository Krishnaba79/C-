using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class Throw1
    {

        static void Main(string[] args)
        {
            //// 1 Default Throw and default Catch 

            //int a = 10, v = 0, c;
            //c = a / v; //default throw
            //Console.WriteLine(c);

            //// 2. Default throw and our catch
            try
            {
                int a = 10, v = 0, c;
                c = a / v; //default throw
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
           

            // 3. Our throw and default catch

            Console.WriteLine("Enter your age");
           // int age = Convert.ToInt16(Console.ReadLine());
           // age = int.Parse(Console.ReadLine());

            //if (age>=18)
            //{
            //    Console.WriteLine("eligible for vote");
            //}
            //else
            //{
            //    throw new Exception("you are not eligible for vote");
            //}
           

            //4. Our throw and our catch.

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt16(Console.ReadLine());
            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("your age eligible for vote..");
                }
                else
                {
                    throw new Exception("your are not eligible for vote");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}