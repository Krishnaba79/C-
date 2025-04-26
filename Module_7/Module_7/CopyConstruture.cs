using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_7
{
    class CopyConstruture
    {
        class user1
        {
            int u_id;
            int age;

            public user1(int id, int u_age)
            {
                u_id = id;
                age = u_age;


            }
            public user1(user1 u)
            {
                u_id = u.u_id;
                age = u.age;

            }
            public void display()
            {
                Console.WriteLine("user_id = " + u_id);
                Console.WriteLine("user_age=" + age);

            }
        }
        static void Main(string[] args)
        {
            user1 u1 = new user1(11, 12);
            u1.display();
            user1 u2 = new user1(u1);
            u1.display();

            Console.ReadLine();
        }
    }
}
