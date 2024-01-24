using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class Course
    {
        //default constructor
        public Course() 
        {
            Console.WriteLine("constructor init");
        }

        static Course()
        {

        }

        //constructor with parameter
        public Course(string name)
        {
            Console.WriteLine(name);
        }

        //destructor
        ~Course()
        {
            Console.WriteLine("destructor hit");
        }
    }
}
