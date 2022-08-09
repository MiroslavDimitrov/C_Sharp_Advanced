using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_advanced
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member public field
        public int age;
        public string JobTitle 
        {
            get
            { 
                return jobTitle;
            }
            set
            { 
                jobTitle = value;
            }
        }

        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member Constructor
        public Members()
        {
            age = 20;
            memberName = "Lucy";
            salary = 20000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        //class cah have only one finalizer
        //cannot be called or inheritated
        ~Members()
        {
            //clean up statesments
            Console.WriteLine("Deconstruction of members object");
        }
    }
}
