using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Interface
{
    internal class RemoteControlJBLSpeaker : IVolume,IPlay
    {
        private int volume = 50;

        public void Next()
        {
            Console.WriteLine("Play Next");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Previous()
        {
            Console.WriteLine("Previous");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        void IVolume.VolumeDown()
        {
            Console.WriteLine("ivolume down");
        }
        void IVolume.VolumeUp()
        {
            Console.WriteLine("ivolume up");
        }

        void IPlay.VolumeDown()
        {
            Console.WriteLine("iplay down");
        }

        void IPlay.VolumeUp()
        {
            Console.WriteLine("iplay up");
        }

        //public void VolumeDown()
        //{
        //    volume--;
        //    if (volume <= 0)
        //        volume = 0;
        //    Console.WriteLine("volume : " + volume);
        //}

        //public void VolumeUp()
        //{
        //    volume++;
        //    if (volume > 100)
        //        volume = 100;
        //    Console.WriteLine("volume : " + volume);
        //}
    }
}
