
using System.Collections;

namespace C_sharp_advanced
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min = MinimumInteger(2000, 5000, 100000, 565555555, 23000000, 1, 456, 45663, 23);
            Console.WriteLine("The minimum value is {0}", min);

            ParamsMethod("My", "name", "is", "Miroslav", "and", "I", "am", "working", "as", "QA");
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "Hobbit";

            ParamsMethodTwo(price, pi, at, book);
            ParamsMethodTwo("Miro", 5.6, '&');

        //    //create instance of a class
        //    Human michael = new Human("Georgi", "Petkov");
        //    Human bo = new Human("Bo", "Sin", "blue", 25);
        //    Human petya = new Human("Petya", "Shopova", "green");
        //    Human todor = new Human("Todor");

        //    Members members = new Members();
        //    members.Introducing(true);
        //    Console.ReadKey();

        //    Box box = new Box(5, 10, 20);
        //    Box boxTwo = new Box(7, 18, 10);
        //    //get the calculate volume directly from the getter
        //    var result = box.Volume;
        //    var frontSurface = box.FrontSurface;
        //    var second = boxTwo.FrontSurface;
        //    Console.WriteLine("{0} {1}", frontSurface, second);
        //    Console.WriteLine(result);
        //    box.DisplayInfo();

        //    //acess public variable from outside, and even change it
        //    //miro.firstName = "Miro";

        //    //call method of the class
        //    todor.Introduction();
        //    petya.Introduction();
        //    michael.IntroduceMyself();
        //    bo.Introduction();
        //    Loops loops = new Loops();
        //    loops.TrainingLoops(20);
        //    Exercise exercise = new Exercise();
        //    exercise.ForLoop();
        //    exercise.WhileLoop();
        //    exercise.Run();

        }

        public class Exercise
        {
            public void ForLoop()
            {
                for (int i = -3; i <= 3; i++)
                {
                    Console.WriteLine(i);
                }
            }

            public void WhileLoop()
            {
                int start = 3;
                while (start >= -3)
                {
                    Console.WriteLine(start);
                    start--;
                }
            }

            public void Run()
            {
                int start = -10;
                while (start <= 10)
                {
                    if (start % 3 == 0)
                    {
                        start++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(start);
                    }

                    start++;

                }
            }
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]  + " ");
            }
        }

        public static void ParamsMethodTwo(params object[] stuff)
        {
            //loop for each object in the array of object
            foreach (object obj in stuff)
            {
                //print each object followed by a space
                //every single class has internal method called tostring
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int MinimumInteger(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                { 
                    min = number;
                }
            }
            return min;
        }

    }
}
