using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _23_Inheritance
{
    internal class Demo
    {
        public void Run()
        {
            //inheritance
            //Person person = new Person("dara");
            //person.Show();

            //Student student = new Student(1, "both", 20, "pp");
            //student.name = "Test";
            //student.Show();

            //Employee employee = new Employee(1, "ratana", "0909090", "pp", 100);
            //employee.Show();

            //Teacher teacher = new Teacher(2, "ratana", "090787878", "pp", 5000, 200);
            //teacher.name = "Test";
            //teacher.salary = 2000;
            //teacher.Show();

            //reference | boxing and unboxing
            //Person person = new Person("dara");
            //Person student = new Student(1, "both", 20, "pp");
            //student.Show();

            //Student tempStudent = (Student)student; //casting
            //tempStudent.Show();

            //can't cast
            //Person person = new Person("dara");
            //Student tempStudent = (Student)person; //casting
            //tempStudent.Show();

            Person person = new Person("dara");
            //person.Print();
            Employee employee = new Employee(1, "ratana", "0909090", "pp", 100);
            Teacher teacher = new Teacher(2, "ratana", "090787878", "pp", 5000, 200);

            //virtual keyword
            Student student = new Student(1, "both", 20, "pp");
            student.Print();
        }
    }
}
