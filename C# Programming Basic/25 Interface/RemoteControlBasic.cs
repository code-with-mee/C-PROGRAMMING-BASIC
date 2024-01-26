using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Interface
{
    internal class RemoteControlBasic : IChannel,IVolume,IPower
    {
        private int channel = 50;
        private int volume = 50;

        public RemoteControlBasic() {
            //PowerOn();
            //Console.WriteLine("chanel : " + channel);
            //Console.WriteLine("volume : " + volume);
        }
        public void ChannelDown()
        {
            channel--;
            if(channel >= 0)
            {
                channel = 100;
            }
            Console.WriteLine("chanel : " + channel);
        }

        public void ChannelUp()
        {
            channel++;
            if(channel > 100)
            {
                channel = 1;
            }
            Console.WriteLine("chanel : " + channel);
        }

        public void PowerOff()
        {
            Console.WriteLine("Power Off");
        }

        public void PowerOn()
        {

            Console.WriteLine("Power On");
        }

        public void VolumeDown()
        {
            volume--;
            if(volume <= 0)
                volume = 0;
            Console.WriteLine("volume : " + volume);
        }

        public void VolumeUp()
        {
            volume++;
            if(volume > 100)
                volume = 100;
            Console.WriteLine("volume : " + volume);
        }
    }
}
