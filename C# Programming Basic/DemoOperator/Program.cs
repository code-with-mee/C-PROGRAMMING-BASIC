using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operator
            /*||  (+ - * / % )  ||*/

            int a = 15;
            int b = 20;

            int c = a + b;
            int d = b - a;
            int e = a * b;

            float g = 11.00f;
            float f = a / g;

            float x = 5;
            float y = 9;
            float zz = x / y;
            float z = x % y;

            //postfix
            int num = 10;
            int num2 = num--;
            //num2 = num + 1;

            //prefix
            int num3 = 10;
            int num4 = --num3;
            //num4 = num3 + 1;

            Console.WriteLine("sum : " + c);
            Console.WriteLine("sub : " + d);
            Console.WriteLine("mul : " + e);
            Console.WriteLine("div : " + zz);
            Console.WriteLine("Mol : " + z);

            Console.WriteLine("{0} | {1}",num3,num4);

            Console.ReadLine();
        }
    }
}
