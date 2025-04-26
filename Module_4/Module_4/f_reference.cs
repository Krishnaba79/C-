using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_4
{
    class f_reference
    {
      public  void Printref(int j)
        {
            Console.WriteLine(j);
            j++;
        }
        static void Main(string[] args)
        {
            f_reference r= new f_reference();
            int x = 10;
            r.Printref(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
