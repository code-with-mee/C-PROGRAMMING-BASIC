using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string
            string firstName = "Ly";
            string lastName = "Ratana";
            //string fullName = firstName +" "+ lastName;
            //string fullName = string.Format("{0} {1}", firstName, lastName);

            //Console.WriteLine(fullName);

            //string[] names = new string[3] {"sal","both","sina"};
            //string name = string.Join(" | ", names);
            //Console.WriteLine(name);

            //char c = firstName[1];
            //Console.WriteLine(c);

            /*
             \n = new line
             \t = new tap
             \\
             \'
             \"
             */
            string data = @"step1 
                            step2
                            step3 
                            step4";
            Console.WriteLine(data);

            //string path = @"c:\data\new folder";
            //Console.WriteLine(path);

            //string data = "hello world \"start\"";
            //Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}
