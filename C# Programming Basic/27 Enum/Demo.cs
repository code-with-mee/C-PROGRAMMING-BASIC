using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Enum
{
    enum LEVEL
    {
        LOW = 50,
        MEDIUM = 80,
        HIGH = 100,
    }
    internal class Demo
    {
        public void Run()
        {
            //enum | enumberations
            LEVEL lv = LEVEL.LOW;
            //Console.WriteLine(lv.ToString());
            //int value = (int)LEVEL.HIGH;
            //Console.WriteLine(value);

            //int quality = 100;
            //LEVEL lv2 = LEVEL.HIGH;

            //if(lv2 == LEVEL.HIGH)
            //    Console.WriteLine("good");

            //Request request = new Request();
            //Request.STATUS status = request.RequestData(200);
            //if(status == Request.STATUS.SUCCESS)
            //{
            //    Console.WriteLine("success");
            //}
            //else if(status == Request.STATUS.NOTFOUND)
            //{
            //    Console.WriteLine("not found");
            //}

            //convert int to enum
            //int statusCode = 200;
            //Request.STATUS status = (Request.STATUS)Enum.ToObject(typeof(Request.STATUS), statusCode); 
            //if(status == Request.STATUS.SUCCESS)
            //{
            //    Console.WriteLine("success");
            //}

            //convert string to enum
            string statusStr = "Success";
            Request.STATUS status = (Request.STATUS)Enum.Parse(typeof(Request.STATUS), statusStr,true);
            if(status == Request.STATUS.SUCCESS)
            {
                Console.WriteLine("success");
            }
        }
    }
}
