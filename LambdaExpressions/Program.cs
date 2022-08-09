using LambdaExpressions;

namespace C_sharp_advanced
{
    class Program
    {
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person personOne = new Person() { Name = "Ivan", Age = 25 };
            Person personTwo = new Person() { Name = "Petar", Age = 20 };
            Person personThree = new Person() { Name = "Lidia", Age = 5 };
            Person personFour = new Person() { Name = "Ilia", Age = 15 };
            Person personFive = new Person() { Name = "Gergana", Age = 10 };

            List<Person> persons = new List<Person>()
            {
                personOne,
                personTwo,
                personThree,
                personFour,
                personFive
            };

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 10 && p.Age <= 20;
            };
            DisplayPeople("Kids", persons, IsMinor);
            DisplayPeople("Kids", persons, filter);
            DisplayPeople("All: ", persons, delegate (Person p) { return true; });

            string searchKeyWord = "A";
            DisplayPeople("Search for people with a keyword: " + searchKeyWord, persons, (p) =>
            {
                if (p.Name.Contains(searchKeyWord)
                && p.Age >= 15)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            DisplayPeople("People who are exactly 25 years old: ", persons, p => p.Age == 25);
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

    }
}