using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(a1.Length);
            int[] a2 = new int[3];
            a2[0] = 2;
            a2[1] = 7;
            a2[2] = 5;

            //Array.Sort(a2);
            //Console.WriteLine("Array.sort");

            //foreach (int i in a2)
            //{
            //    Console.WriteLine(i);

            //}

            //Array.Reverse(a2);
            //Console.WriteLine("Reverse");

            //foreach (int i in a2)
            //{
            //    Console.WriteLine(i);

            //}



            //Console.WriteLine("max= " + a2.Max());

            //Console.WriteLine("max= " + a2.Sum());


            //foreach (int i in a2)
            //{
            //    Console.WriteLine(i);

            //}

            //Array.Resize(ref a2, 7);
            //Console.WriteLine("lenghth = " + a2.Length);

            //Array.ForEach(a2, n => Console.WriteLine(n));

            Console.WriteLine(Array.BinarySearch(a2, 5));

            int p = Array.BinarySearch(a2, 2);
            Console.WriteLine(p);

            Console.ReadLine();

        }
    }
}
