using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_4
{
    class Class1
    {
        public int display(int x,int y)
        {
            return (x + y);
        }

        public void passbyref(out int val)
        {
            val = 5;
            val++;
        }

        public void passbyref(out int x, out int y)
        {
            x = 3;
            y = 5;
        }
    }
}
