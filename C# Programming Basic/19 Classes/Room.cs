using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class Room
    {
        //field
        public int id;
        public string name;
        public int seat;

        //method.
        public void Show()
        {
            Console.WriteLine("id : {0} , name : {1} ,seat : {2}",
                id,name,seat);
        }
    }
}
