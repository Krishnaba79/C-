using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_5
{
    class Formet_e
    {

        static void Main(string[] args)
        {
            try
            {
                int s;
                s = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(s);

            }
            
            finally
            {
                Console.WriteLine("finaly block excute");
            }
            Console.ReadLine();
        }
    }
}