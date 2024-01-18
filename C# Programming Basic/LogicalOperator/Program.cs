using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //logical operators
            // && || !

            bool a = false;
            bool b = true;
            bool c = !b;
            int x = 1;
            int y = 4;
            int z = 3;

            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(c);

            Console.WriteLine(z > x && z > y);

            Console.ReadLine();
        }
    }
}
