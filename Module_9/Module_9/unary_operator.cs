using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Module_9
{

    class A
    {
        int x, y;
        public void set_value(int i, int j)
        {
            x = j;
            y = j;

        }

        public void display()
        {
            Console.WriteLine("X=" + x);
            Console.WriteLine("Y=" + y);
        }

        public static A operator -(A a1)
        {
            A temp= new A();
            temp.x = -a1.x;
            temp.y= -a1.y;
            return (temp);
        }


   }

   class unary_operator
   {
       static void Main(string [] args)
       {
           A a1 = new A();
           a1.set_value(10,20);
           a1.display();

           A a2 = new A();
           a2 = -a1;
           a2.display();

           Console.ReadLine();

       }
   }

}