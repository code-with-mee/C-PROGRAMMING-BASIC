using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type conversion(implicit vs explicit)
            
            //implicit conversion
            byte a = 1;
            int aa = a;

            int b = 1;
            float bb = b;

            //explicit conversion
            //int c = 100000000;
            //byte cc = c;

            int c = 1;
            byte cc = (byte)c; //casting

            float d = 1.5f;
            int dd = (int)d;

            //non-compatible types
            //string e = "1";
            //int ee = e;

            string f = "1";
            int ff = Convert.ToInt32(f);

            string g = "1";
            int gg = int.Parse(g);
            
            string h = "1.4";
            float hh = float.Parse(h);
            Console.WriteLine(hh);
            Console.ReadLine();
        }
    }
}
