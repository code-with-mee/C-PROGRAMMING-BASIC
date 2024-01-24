using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    internal class Teacher
    {
        //properties
        private int id;

        //properties (full property)
        public int Id { 
            get { return id; } 
            set { 
                    if(value > 100) 
                        value = 0;
                    id = value; 
                }
        }

        //automatic property
        public string Name { get; set; }
    }
}
