using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module_7
{
    class CodeFile1
    {
        int e_id, age;
        float pi;

        //  default construstor
        //public CodeFile1()
        //{
        //    //Console.WriteLine("default Construstor");
        //    pi = 3.14f;
        //}

        //  paramatrize construstor
        public CodeFile1(int id, int age)
        {
            e_id = id;
            this.age = age;
        }

        void display()
        {
            Console.WriteLine(e_id);
            Console.WriteLine(age);
        }

        static void Main(string[] args)
        {
            //CodeFile1 c1 = new CodeFile1();
            //Console.WriteLine(c1.pi);

            //CodeFile1 c2 = new CodeFile1();
            //Console.WriteLine(c2.pi);

           // CodeFile1 c1 = new CodeFile1();   // default
            CodeFile1 kajal = new CodeFile1(1,23);
            kajal.display();

            Console.ReadLine();
        }
    }
}
