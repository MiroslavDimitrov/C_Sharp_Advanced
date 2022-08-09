using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Car : Vehicle, IDestroyable
    {

        public string DestructionSound { get; set; }

        public List<IDestroyable> DestryablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosion.mp3";
            DestryablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destroction sound {0}.", DestructionSound);
            Console.WriteLine("Create fire.");
            foreach (var destruction in DestryablesNearby)
            { 
                destruction.Destroy();
            }
        }
    }
}
