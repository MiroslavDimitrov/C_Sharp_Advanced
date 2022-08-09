using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {
        private bool IsHappy { get; set; }

        //to call the base constructor we are using the keyword base
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            //to call the base method we are using the keyword base
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuf! Wuuf! Wuuf!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("I am not happy. I will not play with you.");
            }
        }
    }
}
