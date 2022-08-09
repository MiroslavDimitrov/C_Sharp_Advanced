using Abstraction;

namespace C_sharp_advanced
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Sphere(4),
                new Cube(5),
            };

            foreach (Shape shape in shapes)
            { 
                shape.GetInfo();
#pragma warning disable CS8974 // Converting method group to non-delegate type
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());
#pragma warning restore CS8974 // Converting method group to non-delegate type

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Cube newCube = shape as Cube;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                if (newCube == null)
                {
                    Console.WriteLine("This shape is no cube.");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube.");
                }

                object cubOne = new Cube(7);
                Cube cubTwo = (Cube)cubOne;

                Console.WriteLine("{0} has a volume of {1}.", cubTwo.Name, cubTwo.Volume());
            }
        }
    }
}