using System.Collections;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable < T > for generic collections
            // IEnumerable for non - generic collections

            List<int> numbres = new List<int>() { 1, 3, 5, 7, 9, 11};
            int[] nums = new int[] {2, 4, 6, 8, 10};
            Console.WriteLine();
            SumCollections(nums);

            IEnumerable<int> newUnknownList;
            newUnknownList = GetCollection(1);

            foreach (int num in newUnknownList)
            {
                Console.WriteLine(num + " ");
            }

            DogShelter dogShelter = new DogShelter();

            foreach (Dog dog in dogShelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(3);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }

        static void SumCollections(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbers = new List<int>()
            {
                1, 3, 5, 7, 9, 11, 13
            };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(2);
            numbersQueue.Enqueue(4);
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(10);
            numbersQueue.Enqueue(12);
            numbersQueue.Enqueue(14);

            if (option ==1)
            {
                return numbers;
            }
            else if(option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 15, 16, 17, 18, 19, 20};
            }

        }

        class Dog
        {
            public string Name { get; set; }
            public bool IsNaughtyDog { get; set; }

            public Dog(string name, bool isNaughtyDog)
            {
                this.Name = name;
                this.IsNaughtyDog = isNaughtyDog;
            }

            public void GiveTreat(int numberOfTreats)
            {
                Console.WriteLine("Dog: {0} said wuoff {1} times!", Name, numberOfTreats);
            }
        }

        class DogShelter : IEnumerable<Dog>
        {
            public List<Dog> dogs;

            public DogShelter()
            {
                dogs = new List<Dog>
                {
                    new Dog("Elza", false),
                    new Dog("Bucky", true),
                    new Dog("Lassie", false),
                    new Dog("Tommas", true),
                    new Dog("Beta", false)
                };
            }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return dogs.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}