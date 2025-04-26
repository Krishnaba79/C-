using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Module_9
{
    class myclass
    {
        public int no;

        public static myclass operator +(myclass m1, myclass m2)
        {
            myclass m3 = new myclass();
            m3.no = m1.no + m2.no;
            return (m3);
        }
        public void display()
        {
            Console.WriteLine("No = "+no);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass o1 = new myclass();
            o1.no = 4;

            myclass o2 = new myclass();
            o2.no = 5;
            myclass o3 = new myclass();
            o3 = o1 + o2; //call

            o1.display();
            o2.display();
            o3.display();

            Console.ReadLine();
        }
    }
}
