using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Point
    {
        public float x;
        public float y;
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("x:{0},y:{1}");
        }

        //relation operator
        public static bool operator > (Point p1, Point p2)
        {
            return p1.x > p2.x && p1.y > p2.y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.x < p2.x && p1.y < p2.y;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.x >= p2.x && p1.y >= p2.y;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.x <= p2.x && p1.y <= p2.y;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.x != p2.x || p1.y != p2.y;
        }
    }
}
