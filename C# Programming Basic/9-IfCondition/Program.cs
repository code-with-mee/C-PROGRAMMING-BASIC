using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_IfCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if condition

            int score = 100;
            string grade = score > 50 ? "Good" : "Pass";

            Console.WriteLine(grade);

            Console.ReadLine();
        }
    }
}
