using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class null1
    {

        static void Main(string[] args)
        {
            try
            {
                string s1 = null;
                Console.WriteLine(s1.Length);

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Value can not be null");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}