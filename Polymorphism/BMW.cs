using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BMW : Car
    {
        public string Model { get; set; }
        public string Brand = "BMW";

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"This car is brand {Brand} and it is {Model} model. ");
            base.ShowDetails();
        }

        public override void Repair()
        {
            base.Repair();
            Console.Write($"{Brand} is ready to go!");
            Console.WriteLine();
        }
    }
}
