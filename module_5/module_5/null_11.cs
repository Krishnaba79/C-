using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    class null_11
    {
        static void Main(string[] args)
        {
            // For null


            //string s = "hi";
            //string s = null;
            //Console.WriteLine(s.Length);

            try
            {
                // string s = null;
                string s = "hi";

                Console.WriteLine(s.Length);
            }

            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}