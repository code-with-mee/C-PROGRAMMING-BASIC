using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class DemoRefOut
    {
        //ref and out
        
        public void Show(ref String msg)
        {
            msg = String.Concat(msg, " ", "to c# group");
            Console.WriteLine("1 " + msg);
        }

        public void Print(out string result, String msg)
        {
            result = String.Concat(msg, " ", "to class c#");
            Console.WriteLine("1 " + result);
        }
    }
}
