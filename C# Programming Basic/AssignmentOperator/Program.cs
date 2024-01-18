using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assignment operators
            // = += -= *= /=
            int x = 10;
            x += 1;
            x = x + 1;
            //x -= 2;
            //x *= 2;
            x /= 5;

            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
