using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Inheritance
{
    internal class Teacher : Employee
    {
        public int rate;

        public Teacher() { }    
        public Teacher(int id, string name, string phone, string address, int salary,int rate) :
            base(id,name,phone,address,salary)
        {
            //this.id = id;
            //this.name = name;
            //this.phone = phone;
            //this.address = address;
            //this.salary = salary;
            this.rate = rate;
        }

        public void Show()
        {
            Console.WriteLine("id:{0},name:{1},phone:{2},address:{3},salary:{4},rate:{5}",
                                id, name, phone, address, salary,rate);
        }
    }
}
