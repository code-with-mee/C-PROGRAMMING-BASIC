using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Struct
{
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int x)
        {
            this.x = x;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine("x:{0},y:{1}",x,y);
        }
    }
}
