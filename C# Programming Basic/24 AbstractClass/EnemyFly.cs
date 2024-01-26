using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AbstractClass
{
    internal class EnemyFly : AEnemy
    {
        public override void Attack()
        {
            Console.WriteLine("enemy fly attact");
        }

        public virtual void Fly()
        {
            Console.WriteLine("enemy fly");
        }
    }
}
