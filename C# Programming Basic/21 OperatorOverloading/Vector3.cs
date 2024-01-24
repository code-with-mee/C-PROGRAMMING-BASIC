using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Vector3
    {
        public int x;
        public int y;
        public int z;
        public Vector3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Print()
        {
            Console.WriteLine("x:{0},y:{1},z:{2}",
                            x,y,z);
        }
        public static bool operator true(Vector3 v3)
        {
            return v3.x == 0 && v3.y == 0 && v3.z == 0; 
        }
        public static bool operator false(Vector3 v3)
        {
            return v3.x != 0 || v3.y != 0 || v3.z != 0;
        }
    }
}
