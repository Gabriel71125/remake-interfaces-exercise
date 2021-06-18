using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Interfaces.CORE.Interfaces
{
    interface IPowerable
    {
        bool IsOn { get; set; }

        string PowerOn();
        string PowerOff();
    }
}
