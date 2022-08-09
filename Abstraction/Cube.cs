using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cube : Shape
    {
        public double Lenght { get; set; }

        public Cube(double lenght)
        {
            Name = "Cube";
            this.Lenght = lenght;
        }

        public override double Volume()
        {
            return Math.Pow(Lenght, 3);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The cube has a lenght of {Lenght}.");
        }
    }
}
