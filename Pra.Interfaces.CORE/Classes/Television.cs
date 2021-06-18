using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pra.Interfaces.CORE.Interfaces;

namespace Pra.Interfaces.CORE.Classes
{
   public class Television : ElectricalAppliance, IPowerable, IVolumeChangeable
    {
        public bool IsOn { get; set; }
        public int CurrentVolume { get; private set; } = 50;
        public Television(string room) : base(room)
        {
        }

        public void VolumeUp()
        {
            CurrentVolume += 10;
            if (CurrentVolume > 100)
            {
                CurrentVolume = 100;
            }
        }
        public void VolumeDown()
        {
            CurrentVolume -= 10;
            if (CurrentVolume < 0)
            {
                CurrentVolume = 0;
            }
        }

        public string PowerOff() 
        {
            IsOn = false;
            return $"Tv {Room} is uit";
        }

        public string PowerOn()
        {
            IsOn = true;
            return $"Tv {Room} is aan";
        }
    }
}
