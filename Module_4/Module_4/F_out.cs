using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_4
{
    class F_out
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            int v=4,s;
            c1.passbyref(out v); // 4

            Console.WriteLine(v); // 6
            c1.passbyref(out v, out s);
            Console.WriteLine(v + " " + s);

            Console.ReadLine();
        }
    }
}
