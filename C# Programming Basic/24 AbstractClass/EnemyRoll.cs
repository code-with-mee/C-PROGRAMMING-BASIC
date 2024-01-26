using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AbstractClass
{
    internal class EnemyRoll : EnemyFly
    {
        public EnemyRoll() { }
        public EnemyRoll(string name)
        {
            this.name = name;
        }

        public override void Attack()
        {
            Console.WriteLine("enemy roll attack");
        }

        public override void Fly()
        {
            Console.WriteLine("enemy roll can fly");
        }
    }
}
