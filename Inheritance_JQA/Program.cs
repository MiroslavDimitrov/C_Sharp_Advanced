using Inheritance_JQA;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes(5, 10, 5);
            Rounds rounds = new Rounds(7, 6, 3, 7);
            Rectangles rectangles = new Rectangles(5, 6, 2, 4, 5);
            Rounds cylinder = new Rounds(5, 6, 3, 5);

            shapes.CalculateArea();
            rounds.CalculateParameter();
            rectangles.SumArea();
            rectangles.SumVolume();
            cylinder.CalculateArea();
        }
    }
}