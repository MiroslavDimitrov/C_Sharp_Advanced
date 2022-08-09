using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSecondChallenge
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Boss() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Boss(string name, string firstName, int salary, string companyCar) : base(name, firstName, salary) 
        { 
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I am the leader. My name is {0} {1} and I am driving {2}", FirstName, Name, CompanyCar);
        }

        public override void Work()
        {
            Console.WriteLine("I am working more than 8 hours per day.");
        }
    }
}
