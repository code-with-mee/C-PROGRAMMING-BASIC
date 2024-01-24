using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    public class Math
    {
        //static members
        public static int number = 0;

        static Math()
        {
            number = 100;
        }

        public static void Show()
        {
            
            Console.WriteLine(number);
        }

        public int number2 = 0;
        public void Show2()
        {
            number = 100;
            Console.WriteLine(number2);
        }
    }
}
