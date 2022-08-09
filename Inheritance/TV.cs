using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
           
        }

        //method to listen to the radio
        public void WatchingTv()
        {
            if (IsOn)
            {
                //watching TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //error message
                Console.WriteLine("The TV is switched off, switch it on first.");
            }
        }
    }
}
