using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 1
//namespace Module_4
//{
//    class Program
//    {
//        public void getvalue()
//        {
//            int x;
//            x = Convert.ToInt16(Console.ReadLine());
//        }

//        public void display(int x)
//        {
//            Console.WriteLine(x);
//        }

//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            p.getvalue();
//            p.display();

//            Console.ReadLine();
//        }
//    }
//}

// 2 For get INT value
namespace Module_4
{
    class Program
    {
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
            Program p = new Program();
            Console.WriteLine(p.getvalue());

            int val = p.getvalue();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

