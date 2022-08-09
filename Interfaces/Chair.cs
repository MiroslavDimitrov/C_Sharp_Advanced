using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Chair : Furniture, IDestroyable   
    {

        public string DestructionSound { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Chair(string color, string material)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestroySound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine($"Playimg destrfoction sound {DestructionSound}.");

        }
    }
}
