using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// class Radio inheritates base class ElectricalDevice
    /// </summary>
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
           
        }
      
        //method to listen to the radio
        public void ListenToTheRadio()
        {
            if (IsOn)
            {
                //listening to the radio
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                //error message
                Console.WriteLine("The radio is switched off, switch it on first.");
            }
        }
    }
}
