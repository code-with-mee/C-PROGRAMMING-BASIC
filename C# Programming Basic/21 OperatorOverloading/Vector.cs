using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Vector
    {
        public int x;
        public int y;
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("x:{0},y:{1}", x, y);
        }
        
        public static bool operator &(Vector a, Vector b)
        {
            return a.x == 0 && a.y == 0 &&
                   b.x == 0 && b.y == 0;
        }
        public static bool operator |(Vector a, Vector b)
        {
            return a.x == 0 && a.y == 0 ||
                   b.x == 0 && b.y == 0;
        }
    }
}
