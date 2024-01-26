using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _26_Struct
{
    internal struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x)
        {
            this.x = 0;
            this.y = 0;
        }
        public void Show()
        {
            Console.WriteLine("x:{0},y:{1}",
                x,y);
        }
    }
}
