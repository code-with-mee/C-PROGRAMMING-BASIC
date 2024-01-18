using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while loop
            int number = 0;
            do
            {
                number++;
                Console.WriteLine(number+"welcome!");
            } while (number <= 10);

            Console.ReadLine();
        }
    }
}
