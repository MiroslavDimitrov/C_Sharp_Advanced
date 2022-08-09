using Interfaces;

namespace C_sharp_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair ofiiceChairOne = new Chair("blue", "wood");
            Car car = new Car(23.3f, "red");

            car.Destroy();
        }
    }
}