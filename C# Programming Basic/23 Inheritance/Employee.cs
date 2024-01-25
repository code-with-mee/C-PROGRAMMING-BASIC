using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Inheritance
{
    internal class Employee : Person
    {
        public int id;
        public string phone;
        public string address;
        public int salary;

        public Employee() { }   
        public Employee(int id,string name, string phone, string address, int salary) :base(name) 
        {
            this.id = id;
            //this.name = name;
            this.phone = phone;
            this.address = address;
            this.salary = salary;
        }
        public void Show()
        {
            Console.WriteLine("id:{0},name:{1},phone:{2},address:{3},salary:{4}",
                                id,name,phone,address,salary);
        }
    }
}
