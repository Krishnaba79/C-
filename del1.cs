using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_delegate
{
    //Define the delegate

    public delegate void MyDelegate(string message);
    //create methods that match the delegate Signature

    public class prdel1
    {

        public static void Fun1(string message)

        {

            Console.WriteLine("Function1 says:" + message);
        }
        public static void Fun2(string message)
        {
            Console.WriteLine("Function2 says:" + message);
        }
        //Instantiate the Delegate and Invoke Methods
        static void Main(string[] args)
        {
            //Instantiate delegate with Function1
            MyDelegate del1 = new MyDelegate(Fun1);

            del1("Hi from function1");

            //Instantiate delegate with Function2
            MyDelegate del2 = new MyDelegate(Fun2);

            del2("Hello from function2");


            //Multicast Delegate
            MyDelegate del3 = del1 + del2;

            //call the multicast delegate
            del3("Hello from both functions");


        }
    }
        }

