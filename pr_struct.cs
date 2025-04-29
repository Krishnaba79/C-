using System;


namespace Struct_Sample
{
    struct employee1
    {
        public int id;
        public string name;
        public int age;

        public void getid(int id)
        {
            Console.WriteLine("Id of employee is:" + id);
        }

        public void getName(string name) {
            Console.WriteLine("Name of employee is:" + name);

        }
        public void getAge(int age) {
            Console.WriteLine("Age of employee is:" + age);
        }
    }
    class Pstr
    {
        static void Main(string[] args)
        {

            employee1 emp = new employee1();

            emp.id = 1;
            emp.getid(emp.id);
            Console.ReadLine();


            emp.name = "abc";
            emp.getName(emp.name);
            Console.ReadLine();

            emp.age = 23;
            emp.getAge(emp.age);
            Console.ReadLine();

        }
    }
}
            



    
