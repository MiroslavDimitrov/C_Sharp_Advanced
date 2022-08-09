using Delegates;

namespace C_sharp_advanced
{
    class Program
    {

        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {

            Person personOne = new Person() { Name = "Ivan", Age = 25};
            Person personTwo = new Person() { Name = "Petar", Age = 20};
            Person personThree = new Person() {Name = "Lidia", Age = 5 };
            Person personFour = new Person() { Name = "Ilia", Age = 15};
            Person personFive = new Person() { Name = "Gergana", Age = 10};

            List<Person> persons = new List<Person>() 
            {
                personOne,
                personTwo,
                personThree,
                personFour,
                personFive
            };

            DisplayPeople("Kids", persons, IsMinor);

            Console.WriteLine();
            List<string> names = new List<string>()
            { 
                "Maria", 
                "Petya",
                "Nadya",
                "Georgi",
                "Miroslav",
                "Angel"
            };

            Console.WriteLine("BEFORE");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("AFTER");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0} is {1} years old.", p.Name, p.Age);
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsMature(Person p)
        {
            return p.Age > 18;
        }

        static bool Filter(string str)
        {
            return str.Contains("i");
        }
    }
}