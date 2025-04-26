using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_4
{
    class File3
    {
        static void Main(string[] args)
        {
            File1 f = new File1();
            File2 F = new File2();

            Console.WriteLine(" First add method : ");
            Console.WriteLine(f.add(2, 3)); // 5

            Console.WriteLine(" Second add method : ");
            Console.WriteLine(F.add(5, 6, 7)); // 18

            Console.WriteLine(" Third add method : ");
            F.add(2 , 3.14f , "XYZ");

            Console.ReadLine();

        }
    }
}
