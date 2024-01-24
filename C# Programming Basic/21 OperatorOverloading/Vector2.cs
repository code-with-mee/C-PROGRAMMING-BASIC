using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Vector2
    {
        public int x;
        public int y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //unary operator
        public static Vector2 operator +(Vector2 v)
        {
            v.x = +v.x;
            v.y = +v.y;
            return v;
        }

        public static Vector2 operator -(Vector2 v)
        {
            v.x = -v.x;
            v.y = -v.y;
            return v;
        }

        public void Print()
        {
            Console.WriteLine("x:{0},y:{1}",x,y);
        }
    }
}
