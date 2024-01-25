using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers
{
    internal class NameList
    {
        private string[] names = new string[5];

        //indexer
        public string this[int index]
        {
            get
            {
                if(index < 0 || index >= names.Length-1)
                    throw new ArgumentOutOfRangeException("index");
                return names[index];
            }
            set
            {
                if (index < 0 || index >= names.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                names[index] = value;
            }
        }
    }
}
