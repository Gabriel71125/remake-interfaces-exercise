using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pra.Interfaces.CORE.Interfaces;

namespace Pra.Interfaces.CORE.Classes
{
    public class SmartLamp : ElectricalAppliance, IPowerable
    {
        public bool IsOn { get; set; }
        public int CurrentVolume { get; private set; } = 50;

        public SmartLamp(string room) : base(room)
        {
        }

        public string PowerOff()
        {
            IsOn = false; return $"Smartlamp {Room} is uit";
        }
        public string PowerOn()
        {
            IsOn = true; return $"Smartlamp {Room} is aan";
        }
    }
}
