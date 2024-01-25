using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers
{
    internal class BoxList
    {
        public int[,] numbers = new int[5, 5];

        //indexer
        public int this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= numbers.Length - 1 || y < 0 || y >= numbers.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                return numbers[x, y]; 
            }
            set
            {
                if (x < 0 || x >= numbers.Length - 1 || y < 0 || y >= numbers.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                numbers[x, y] = value;
            }
        }
    }
}
