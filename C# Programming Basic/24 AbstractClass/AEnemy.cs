using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_AbstractClass
{
    internal abstract class AEnemy
    {
        public string name;
        public abstract void Attack();
        public virtual void Print()
        {
            Console.WriteLine("print abstract");
        }
    }
}
