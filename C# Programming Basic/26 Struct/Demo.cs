using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Struct
{
    internal class Demo
    {
        public void Run()
        {
            //struct
            //class object => references type
            //struct => value type

            //Coordinate coordinate = new Coordinate();
            Coordinate coordinate;
            coordinate.x = 5;
            coordinate.y = 5;

            Coordinate coordinate2 = coordinate;
            coordinate2.x = 100;

            //coordinate.Show();
            //coordinate2.Show();

            //struct constructor
            //Point p = new Point(5,5);
            //p.Show();
            //Point p2 = new Point(5);
            //p2.Show();

            Point p3 = new Point();
            //p3.Show();

            Point p4;
            p4.x = 100;
            p4.y = 100;
            p4.Show();
        }
    }
}
