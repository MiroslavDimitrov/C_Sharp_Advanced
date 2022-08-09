using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSecondChallenge
{
    class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Employee() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I am working.");
        }

        public virtual void Pause()
        {
            Console.WriteLine("I am at lanch break.");
        }
    }
}
