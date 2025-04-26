using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayCollection
{
    class Array_List
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("krishnaba");
            al.Add("solanki");
            al.Insert(2, 29);
            al.Remove(2);

            foreach (var l in al)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
            



            

        }
    }
}