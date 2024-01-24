using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class Group
    {
        public int id;
        public string name;

        public Group() { }
        public Group(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //this keyword
        public void Show()
        {
            Console.WriteLine("{0} , {1}",
                this.id,this.name);
        }

    }
}
