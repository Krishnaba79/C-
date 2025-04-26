﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_11
{
    class shap// parent, super,base
    {
        public int width;//l*w
        public int lendth;

    }
    class rectangle : shap//child,derived,sub
    {
        public void getvalue(int l, int w)//l=2 w=3
        {
            width = w;//2
            lendth = l;//3

        }

    }
    //class A:rectangle  //Multilevel
    //{
    //    public void Area()
    //    {
    //        Console.WriteLine("Area= " + width * lendth);
    //    }
    //}
    class circle : shap // hierachical
    {

    }
    class square : shap //hierachical
    {
    }


    class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.getvalue(2, 3);
            // r.Area();
            A a1 = new A();


            Console.ReadLine();
        }
    }
}