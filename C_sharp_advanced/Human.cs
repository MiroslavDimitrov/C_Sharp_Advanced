using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_advanced
{
    public class Human
    {
        //member variable
        //value will be Michael untill we change it
        private string firstName = "Michael";
        private string lastName;
        private string eyeColour;
        private int age;

        //default constuctor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Human()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Human(string firstName)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.firstName = firstName;
        }

        //parameterized constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Human(string firstName, string lastName)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColour, int age)
        { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }

        public void Introduction()
        {
            if (age != 0 && lastName != null && eyeColour != null)
            {
                Console.WriteLine("My name is {0} {1}. My eye colour is: {2} and I am {3} year old.", firstName, lastName, eyeColour, age);
            }
            else if (firstName != null && age == 0 && lastName == null && eyeColour == null)
            {
                Console.WriteLine("Hi, my name is {0}", firstName);
            }
            else
            {
                Console.WriteLine("My name is {0} {1}. My eye colour is: {2}.", firstName, lastName, eyeColour);
            }
        }
    }
}
