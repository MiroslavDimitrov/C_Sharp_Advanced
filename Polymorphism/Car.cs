using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //has a relationship
        protected CarIDInfo carIdInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the id {carIdInfo.IDNum} and it owner is {carIdInfo.Owner}");
        }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Car()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"This car has a {HP} hp and it is in {Color} color.");
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car was repaired!");
        }
    }
}
