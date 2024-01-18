using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BreakContinueGoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //break | continue | goto

            for(int i = 1; i<=10;i++)
            {
                Console.WriteLine("1");
                if (i >= 5)
                {
                    goto gotohere;
                    break;
                }

                if (i % 2 == 0)
                    continue;
                Console.WriteLine("2");
                Console.WriteLine("========");

            }

            Console.WriteLine("3");

            gotohere:
                Console.WriteLine("4");

            Console.ReadLine();
        }
    }
}
