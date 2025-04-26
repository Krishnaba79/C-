using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_4
{
    class A
    {
        public int x, y;
    }
    
    class B
    {
        public int x, y;
    }

    class Diffclass
    {
        static void Main(string[] args)
        {
            A a1 = new A(); // Object
            B b1 = new B();

            a1.x = 10;
            a1.y = 5;

            b1.x = 6;
            b1.y = 7;


            Console.WriteLine("Class A");
            Console.WriteLine("X = " + a1.x);
            Console.WriteLine("Y = " + a1.y);

            Console.WriteLine("Class B");
            Console.WriteLine("X = " + b1.x);

            Console.ReadLine();
        }
    }
}
