using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ElectricalDevice
    {
        //boolean to determine the state of the device
        public bool IsOn { get; set; }
        //name of the device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //switch on the device
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the device
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
