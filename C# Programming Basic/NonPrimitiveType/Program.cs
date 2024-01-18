using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimitiveType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //non-primitive type
            /*
                - classes
                - struct
                - enum
                - array
                - string
    
            */

            int a = 1;
            int b = 2;
            int[] numbers = new int[3];
            numbers[0] = 100;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);

            int[] ages = new int[3] { 34,56,78};
            ages[2] = 100;
            //Console.WriteLine(ages[2]);

            string[] names = new string[3] { "ratha","both","virak"};
            Console.WriteLine(names[0]);

            Console.ReadLine();
        }
    }
}
