using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_delegate
{
    // Define a custom delegate with a string parameter and void return type
    delegate void CustomCallback(string s);

    class TestClass
    {
        static void Hello(string s) { Console.WriteLine($"Hello, {s}!"); }
        static void Goodbye(string s) { Console.WriteLine($"Goodbye, {s}!"); }

        static void Main()
        {
            CustomCallback hiDel, byeDel, multiDel, multiMinusHiDel;

            // Initialize delegate objects
            hiDel = Hello;
            byeDel = Goodbye;

            // Combine delegates
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate
            multiMinusHiDel = multiDel - hiDel;

            // Invoke delegates
            hiDel("A");
            byeDel("B");
            multiDel("C");
            multiMinusHiDel("D");
        }
    }

}
