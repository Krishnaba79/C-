using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCollection
{
    class Stack_example
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);

            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            myStack.Pop();
            myStack.Pop();
            myStack.Push(5);
            myStack.Push(6);


            foreach (var item in myStack)
            {
                Console.Write(item + ",");      //prints 4,3,2,1
            }

            myStack.Pop();
            Console.WriteLine("---------------");

            foreach (var item in myStack)
            {


            }

            Console.WriteLine("Peek = " + myStack.Peek());
            Console.WriteLine("contain=" + myStack.Contains(2));
            Console.ReadLine();

        }
    }
}
