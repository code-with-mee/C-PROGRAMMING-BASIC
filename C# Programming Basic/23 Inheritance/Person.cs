using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Inheritance
{
    internal class Person
    {
        public string name;

        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }   
        public void Show()
        {
            Console.WriteLine("name:{0}",name);
        }

        public virtual void Print()
        {
            Console.WriteLine("print person");
        }
    }
}
