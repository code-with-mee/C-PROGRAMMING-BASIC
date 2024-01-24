using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class DemoMethod
    {
        //demo method
        //no return no parameter
        public void Print()
        {
            Console.WriteLine("Hello");
        }

        //no return with parameter
        public void Send(String message)
        {
            Console.WriteLine(message);
        }

        //return with no parameter
        public float GetPI()
        {
            return 3.14f;
        }

        //return with parameters
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
