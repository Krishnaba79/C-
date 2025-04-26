using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_7
{
    class defaultconstracture   
    {

        static defaultconstracture()
        {
            Console.WriteLine(" i am static");

        }
        public defaultconstracture()
        {
            Console.WriteLine("i am default");

        }
        static void Main(String[] args)
        {
            defaultconstracture s1 = new defaultconstracture();
            defaultconstracture s2 = new defaultconstracture();
            Console.ReadLine();
        }

    }
}
