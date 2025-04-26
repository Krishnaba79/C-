using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_2
{
    class Getvalue1
    {
        //public void getvalue()
        //{
        //    int x;
        //    x = Convert.ToInt16(Console.ReadLine());
        //}
        //static void Main(string[] args)
        //{
        //    Getvalue1 p = new Getvalue1();
        //    p.getvalue();   // this type code will take input only and will not print the value type inputed
            
        //    Console.ReadLine();

        // -----------------------------------------------------------------------------------------------------

        //public void getvalue()
        //{
        //    int x;
        //    x = Convert.ToInt16(Console.ReadLine());
        //    display(x);
        //}

        //public void display(int x)
        //{
        //    Console.WriteLine(x);
        //}

        //static void Main(string[] args)
        //{
        //    Getvalue1 p = new Getvalue1();
        //    p.getvalue();   // this type code will take input only and will print the value type inputed

        //    Console.ReadLine();

        // -----------------------------------------------------------------------------------------------------

        public int getvalue()
        {
            int x;
            x = Convert.ToInt16(Console.ReadLine());
            return (x);
        }

        public void display(int x)
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Getvalue1 p = new Getvalue1();
            Console.WriteLine(p.getvalue());

            int val = p.getvalue();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
