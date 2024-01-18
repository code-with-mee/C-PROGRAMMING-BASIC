using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch
            string day = "sunday123";
            switch(day)
            {
                case "monday": Console.WriteLine("monday");
                                break;
                case "tuesday": Console.WriteLine("tuesday"); 
                                break;
                case "wednesday": Console.WriteLine("wednesday"); 
                                break;
                case "thursday": Console.WriteLine("thursday"); 
                                break;
                case "friday": Console.WriteLine("friday"); 
                                break;
                case "saturday": Console.WriteLine("saturday"); 
                                break;
                case "sunday": Console.WriteLine("sunday");
                                break;
                default : Console.WriteLine("default"); 
                                break;
            }


            Console.ReadLine();
        }
    }
}
