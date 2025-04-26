using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class CodeFile2
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("1st Statement: ");
            goto skip; //goto label skip:
            
            l2:
           i++;//4
            Console.WriteLine("2nd Statement: ");  // skip this stat
             skip: //label:
            Console.WriteLine("3rd Statement: ");
            while (i != 3)
             {
                 goto l2;
                
             }
            
            Console.ReadKey();
        }
    }
}