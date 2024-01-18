using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string

            string message = "welcome";
            string message2 = "to class.";

            //length
            //Console.WriteLine(message.Length);

            //join
            //Console.WriteLine(message + message2);
            //Console.WriteLine(String.Concat(message," ",message2));

            //equal
            //Console.WriteLine(message == message2);
            if (message.Equals(message2))
            {
                Console.WriteLine("is equal");
            }

            // string format
            string msg = string.Format("Hello, {0} {1} again.", message, message2);
            //Console.WriteLine(msg);

            //split
            string data = "rith,both,virak,sina,chantra,pheakdey";
            string[] names = data.Split(',');
            foreach (string name in names)
            {
                //Console.WriteLine(name);
            }

            //substring
            string m = message.Substring(0, 3);
            //Console.WriteLine(m);

            //contain
            if(message.Contains("wel"))
            {
                //Console.WriteLine(message);
            }

            //trim
            string message3 = " welcome ";
            //Console.WriteLine(message3.Length);
            //Console.WriteLine(message3.Trim().Length);

            //toupper to lower
            //Console.WriteLine(message3.ToUpper());
            //Console.WriteLine(message3.ToLower());

            //chararray
            char[] characters = message3.ToCharArray();
            foreach (char c in characters)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
