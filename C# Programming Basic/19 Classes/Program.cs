using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class
            /*
             what is class ?
             what is an object ?
             OOP : Object Oriented Programming
                - Encapsulation
                - Inheritance
                - Polymorphism
             */

            int[] numbers = new int[9];

            //object
            Student student = new Student();
            student.id = 1;
            student.name = "chenda";
            student.age = 30;

            Teacher teacher = new Teacher();
            teacher.Id = 200;

            Room room = new Room();
            room.id = 100;
            room.name = "C# Room";
            room.seat = 25;

            //room.Show();

            DemoMethod demo = new DemoMethod();
            //demo.Print();
            //demo.Send("Welcome");

            float pi = demo.GetPI();
            //Console.WriteLine(pi);

            int sum = demo.Sum(3, 4);
            //Console.WriteLine(sum);


            //Course course = new Course("C# programming");
            //Math.number = 100;
            //Math.Show();

            //Math.number = 1000;
            //Math.Show();

            Math m = new Math();
            m.number2 = 90;
            //m.Show2();

            Math m2 = new Math();
            m2.number2 = 500;
            //m2.Show2();

            DemoRefOut ro = new DemoRefOut();

            //string msg = "Welcome";
            //ro.Show(ref msg);
            //Console.WriteLine("2 " + msg);

            //out
            string msg = "welcome";
            string result = "";
            //ro.Print(out result, msg);
            //Console.WriteLine("2 " + result);

            Calculate cal = new Calculate();
            int[] nums = { 10, 15, 5 };
            //cal.Sum(nums);
            cal.Sum(10,15,5,3,5,7,8,9);
            cal.Mul(10,15);
            Console.ReadLine();
        }
    }
}
