using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_pr
{
     class Encapsulation
    {
        

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private string studentName;
        private int studentAge;

        // using accessors to get and
        // set the value of studentName
        public string Name
        {

            get { return studentName; }

            set { studentName = value; }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {

            get { return studentAge; }

            set { studentAge = value; }
        }
    }

    // Driver Class
    class Encp1
    {

        // Main Method
        static public void Main()
        {

            // creating object
            Encapsulation obj = new Encapsulation();

            // calls set accessor of the property Name,
            // and pass "VisualStudio" as value of the
            // standard field 'value'
            obj.Name = "Rohit";
            

            // calls set accessor of the property Age,
            // and pass "23" as value of the
            // standard field 'value'
            obj.Age = 23;

            // Displaying values of the variables
            Console.WriteLine(" Name : " + obj.Name);
            Console.WriteLine(" Age : " + obj.Age);
        }
    }

}

