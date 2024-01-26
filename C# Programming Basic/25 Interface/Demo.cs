using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Interface
{
    internal class Demo
    {
        public void Run()
        {
            //interface
            RemoteControlBasic rcb = new RemoteControlBasic();
            //rcb.PowerOn();
            //rcb.ChannelUp();
            //rcb.ChannelUp();

            //rcb.VolumeUp();
            //rcb.VolumeUp();
            //rcb.VolumeUp();
            //rcb.VolumeUp();
            //rcb.VolumeUp();
            //rcb.PowerOff();

            RemoteControlSmartTV smartTV = new RemoteControlSmartTV();
            //smartTV.PowerOn();
            //smartTV.VolumeUp();
            //smartTV.VolumeUp();
            //smartTV.VolumeUp();
            //smartTV.VolumeUp();
            //smartTV.PlayYoutube();
            //smartTV.PlayNetflix();
            //smartTV.PowerOff();

            //interface references
            IVolume sTv = new RemoteControlSmartTV();  
            
            //conflict of interface
            IVolume jBLSpeaker = new RemoteControlJBLSpeaker();
            jBLSpeaker.VolumeDown();
            jBLSpeaker.VolumeUp();
        }
    }
}
