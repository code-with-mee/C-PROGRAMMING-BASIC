using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datetime

            DateTime dt = new DateTime(2020, 1, 1);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            //DateTime tomorrow = today.AddDays(2);
            //DateTime yesterday = today.AddDays(-1);
            //Console.WriteLine(yesterday.ToString());

            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToShortTimeString());

            Console.WriteLine(today.ToString());

            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));


            Console.ReadLine();
        }
    }
}
