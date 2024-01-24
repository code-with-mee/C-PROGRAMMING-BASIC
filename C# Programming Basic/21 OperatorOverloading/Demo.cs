using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OperatorOverloading
{
    internal class Demo
    {
        public void Run()
        {
            //operator overloading
            /*
             * unary operator
             * binary operator
             * relational operator
             * logical operator
             * true and false operator
             * conversion operator
             */

            //unary operator overloading
            Vector2 v = new Vector2(4,5);
            //v.Print();
            //v = -v;
            //v.Print();

            //binary operator overloading (+-*/)
            Box b = new Box(100, 500);
            Box b2 = new Box(20, 15);
            //Box b3 = b + b2;
            //Box b3 = b - b2;
            //Box b3 = b * b2;
            Box b3 = b / b2;
            //b3.Print();

            //relational operator overloading
            //(==,!=,<,>,<=,>=)
            Point p = new Point(100, 100);
            Point p2 = new Point(100, 100);
            //Console.WriteLine(p == p2);
            //Console.WriteLine(p != p2);
            //Console.WriteLine(p > p2);
            //Console.WriteLine(p >= p2);
            //Console.WriteLine(p < p2);
            //Console.WriteLine(p <= p2);

            //logical operator overloading
            //(&&,||)
            Vector vv = new Vector(1,0);
            Vector vv2 = new Vector(0, 1);
            //Console.WriteLine( vv & vv2);
            //Console.WriteLine(vv | vv2);

            //true and false operator
            //(true,false)
            Vector3 v3 = new Vector3(0,0,0);
            if(v3)
            {
                //Console.WriteLine("v3 is zero");
            }
            else
            {
                //Console.WriteLine("v3 any of vector not zero");
            }

            //conversion operator overloading
            Box c1 = new Box(10, 10);
            Box c2 = new Box(10, 10);
            Box c3 = c1 + c2;
            c3.Print();
            int total = c3;
            Console.WriteLine("total : " + total);
        }
    }
}
