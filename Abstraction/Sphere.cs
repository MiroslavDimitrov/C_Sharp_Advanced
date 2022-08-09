using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double area)
        {
            Name = "Spere";
            this.Radius = area;
        }

        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"\nThe sphere has radius {Radius}");
        }
    }
}
