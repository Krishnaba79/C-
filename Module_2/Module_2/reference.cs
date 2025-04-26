using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_2
{
    class reference
    {
        void printref(ref int j)
        {
            Console.WriteLine(j);
            j++;
            //Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            reference r = new reference();
            int x = 10;
            r.printref(ref x);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
