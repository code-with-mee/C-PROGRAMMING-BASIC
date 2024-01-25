using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Inheritance
{
    internal class Student : Person
    {
        public int id;
        public int age;
        public string address;

        public Student() { }
        public Student(int id,string name, int age, string address) : base(name)
        {
            this.id = id;
            //this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Show()
        {
            //base.Show();
            Console.WriteLine("id:{0},name:{1},age:{2},address:{3}",
                            id,name,age,address);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("print student");
        }
    }
}
