using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi : Car
    {
        private string Model { get; set; }
        private string Brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"This car is brand {Brand} and it is {Model} model. ");
            base.ShowDetails();
        }


        //if we replace the keyword ovveride with new
        //it will not override thebase method, it will prioritize this one with the keyword new
        public override void Repair()
        {
            base.Repair();
            Console.Write($"This {Brand} is ready to go!");
        }
    }
}
