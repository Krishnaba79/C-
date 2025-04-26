using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(x);
            Console.WriteLine("x=" +x+ "y=" + y); // concatenation

            Console.WriteLine("x={0} y={1}", x, y);

        }
    }
}
