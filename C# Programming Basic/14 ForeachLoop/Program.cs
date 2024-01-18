using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach loop
            int[] ages = { 12,45,34,56,78,90};
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            string[] names = {"botrey","simon","rith" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
