using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AbstractClass
{
    internal class Demo
    {
        public void Run()
        {
            //abstract class
            EnemyFly eFly = new EnemyFly();
            eFly.Attack();
            eFly.Fly();

            EnemyGround eGround = new EnemyGround();
            eGround.Attack();
            eGround.Print();

            EnemyRoll eRoll = new EnemyRoll();
            eRoll.Attack();
            eRoll.Fly();
            eRoll.Print();
        }
    }
}
