using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Interfaces.CORE.Classes
{
    public abstract class ElectricalAppliance
    {
        public string Room { get; private set; }

        public ElectricalAppliance(string room)
        {
            Room = room;
        }
    }
}
