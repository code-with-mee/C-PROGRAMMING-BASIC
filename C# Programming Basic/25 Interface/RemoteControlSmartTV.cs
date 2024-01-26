using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Interface
{
    internal class RemoteControlSmartTV : RemoteControlBasic, ISmartApp
    {
        public void PlayGame()
        {
            Console.WriteLine("Play game");
        }

        public void PlayNetflix()
        {
            Console.WriteLine("Play netflix");
        }

        public void PlayYoutube()
        {
            Console.WriteLine("Play youtube");
        }
    }
}
