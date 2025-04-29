using System;

namespace Encapsulation
{
    class Encapsulation
    {
        private string emp_name;
        private int emp_age;

        public string name
        {
            get { return emp_name; }
            set { emp_name = value; }
        }
        public int age
        {
            get { return emp_age; }
            set { emp_age = value; }
        }
    }
    class emp_main
    {
        public static void Main(string[] args)
        {
            Encapsulation e1 = new Encapsulation();
            e1.name = "Rohit";
            e1.age = 30;
            Console.WriteLine("Employee name is: " + e1.name);
            Console.WriteLine("Employee age is :" + e1.age);
        }
    }
}