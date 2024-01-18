using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop
            // for
            // while
            // do while
            // foreach

            string[] names = { "both", "sina", "chenda", "virak" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}
