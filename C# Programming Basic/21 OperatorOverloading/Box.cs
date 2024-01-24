using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Box
    {
        public int x;
        public int y;
        public Box(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //binary operator
        public static Box operator +(Box a, Box b)
        {
            Box b3 = new Box(0, 0);
            b3.x = a.x + b.x;
            b3.y = a.y + b.y;
            return b3;
        }
        public static Box operator -(Box a, Box b)
        {
            Box b3 = new Box(0, 0);
            b3.x = a.x - b.x;
            b3.y = a.y - b.y;
            return b3;
        }
        public static Box operator *(Box a, Box b)
        {
            Box b3 = new Box(0, 0);
            b3.x = a.x * b.x;
            b3.y = a.y * b.y;
            return b3;
        }
        public static Box operator /(Box a, Box b)
        {
            Box b3 = new Box(0, 0);
            b3.x = a.x / b.x;
            b3.y = a.y / b.y;
            return b3;
        }

        //conversion operator overloading
        public static implicit operator int(Box b)
        {
            return b.x + b.y;
        }
        public void Print()
        {
            Console.WriteLine("x:{0},y:{1}",x,y);
        }
    }
}
