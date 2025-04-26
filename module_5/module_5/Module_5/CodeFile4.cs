using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class CodeFile4
    {

        static void Main(string[] args)
        {
            int a = 10, b = 0, c;

            try
            {
                c = a / b;
            }
            catch(Exception e)
            {
               //onsole.WriteLine("b can not  zero");
                Console.WriteLine(e.Message);

            }


            //if (b == 0)
            //{
            //    Console.WriteLine("b value can not zero");

            //}
            //else
            //{
            //    c = a / b;
            //    Console.WriteLine(c);

            //}
         
           
            Console.WriteLine("Continue code");
//Logically error handled

            //if (b == 0)
            //{
            //    Console.WriteLine("b can not  zero");

            //}
            //else
            //{
            //    int c = a / b;
            //}
            Console.ReadLine();
        }
    }
}