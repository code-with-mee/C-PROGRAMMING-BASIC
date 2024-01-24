using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal partial class Calculate
    {
        //params array
        public void Mul(params int[] numbers)
        {
            int mul = 0;
            foreach (int number in numbers)
            {
                mul *= number;
            }
            Console.WriteLine(mul);
        }
    }
}
