using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Enum
{
    public class Request
    {
        public enum STATUS
        {
            SUCCESS = 200,
            NOTFOUND = 404
        }

        public STATUS RequestData(int number)
        {
            if(number > 100)
                return STATUS.SUCCESS;
            else
                return STATUS.NOTFOUND;
        }
    }
}
