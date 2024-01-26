using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Interface
{
    internal interface IPlay
    {
        void Play();
        void Stop();
        void Pause();
        void Next();
        void Previous();
        void VolumeUp();
        void VolumeDown();
    }
}
