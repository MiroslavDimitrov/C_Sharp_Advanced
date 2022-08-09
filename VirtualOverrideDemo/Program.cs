using VirtualOverrideDemo;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Elza", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.Eat();
            dog.Play();
            dog.MakeSound();
        }
    }
}