using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class Multiplecatch
    {
        static void Main(string[] args)
        {
           // int a , b;

            //try
            //{
            //   //// a = int.Parse(Console.ReadLine());
            //   //// b = int.Parse(Console.ReadLine());
            //   //string b1 = null;
            //   //Console.WriteLine(b1.Length);
            //   // int c = a / b;
            //   // Console.WriteLine("C VALUE = " + c);
               
            //}
           
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            try
            {
               int a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());
               Console.WriteLine(a / b);
               string s1 = null;
               Console.WriteLine(s1.Length);
            }
           
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            Console.ReadLine();
        }
    }
}