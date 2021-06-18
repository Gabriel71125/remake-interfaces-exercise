using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pra.Interfaces.CORE.Interfaces;

namespace Pra.Interfaces.CORE.Classes
{
    public class Radio : ElectricalAppliance, IPowerable, IVolumeChangeable, IConnectionCheckable
    {
        public bool IsOn { get; set; }
        public int CurrentVolume { get; private set; } = 50;

        public Radio(string room) : base(room)
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
            IsOn = false; return $"Radio {Room} is uit"; 
        }
        public string PowerOn()
        {
            IsOn = true; return $"Radio {Room} is aan";
        }
        public string CheckBroadcastConnection()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"=========== Testing {this.GetType().Name} {Room} ===========");
            stringBuilder.AppendLine("Is antenna extended? Checking antenna...");
            stringBuilder.AppendLine($"Antenna extended test returns {IsAntennaExtended()}");
            stringBuilder.AppendLine("Is FM working? Checking FM...");
            stringBuilder.AppendLine($"FM working test returns {IsFmWorking()}");
            stringBuilder.AppendLine($"---------- End of test {this.GetType().Name} {Room} ----------" +
                $" {Environment.NewLine}");
            
            return stringBuilder.ToString();
        }
    }
}
