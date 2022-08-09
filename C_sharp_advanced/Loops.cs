using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_advanced
{
    public class Loops
    {
        public void TrainingLoops(int counter)
        {
            //print odd numbers
            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //print even numbers
            do
            {
                Console.WriteLine(counter);
                counter -= 2;

            } while (counter >= 0);
            Console.WriteLine();

            List<string> names = new List<string>();
            names.Add("Miro");
            names.Add("Georgi");
            names.Add("Nadya");
            names.Add("Maria");
            names.Add("Petar");
            names.Add("Tanya");

            int count = names.Count;

            while (count > 0)
            {
                Console.WriteLine(names[count - 1]);
                count -= 1;
            }
            Console.WriteLine();

            foreach (var name in names)
            {
                Console.WriteLine($"My name is {name}");
            }
        }
    }
}
