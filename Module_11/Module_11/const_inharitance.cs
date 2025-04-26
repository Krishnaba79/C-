using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace Module_11
{
    class a1    //parent
    {
        public a1(int x)
        {
            Console.WriteLine("base class a1= " + x);
        }
    }
    class B1 : a1   //child
    {
        public B1()
            : base(10)//parent
        {
            Console.WriteLine("child class b1");
        }
    }

    class const_inharitance
    {
        static void Main(string[] args)
        {
            // a1 a = new a1();
            B1 b = new B1();

            Console.ReadLine();
        }
    }
}