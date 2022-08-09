using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSecondChallenge
{
    class Trainees : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainees() { }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am at school for {0} hours per day.", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("Hi, my name is {0} {1}. I am at work {2} hours per workday.",Name, FirstName, WorkingHours);
        }
    }
}
