using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int number = 0;
            while(number < 100)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(number +  " => welcome!");
                //number++;
            }

            Console.ReadLine();
        }
    }
}
