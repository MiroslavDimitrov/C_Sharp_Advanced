using Polymorphism;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new BMW(350, "wellow","BMW 406"),
                new Audi(250, "blue", "Audi 206")
            };

            foreach (var car in cars)
            {
                car.Repair();
                car.ShowDetails();
            }

            //polymorphism, also can be done with a metnods
            Car carOne = new BMW(400, "blue", "BMW 200");
            Audi carTwo = new Audi(230, "blue", "Audi 105");
            Car carThree = (Car)carOne;
            carOne.SetCarIDInfo(1, "Me");
            carOne.GetCarIDInfo();
            carOne.ShowDetails();
            carThree.ShowDetails();
            Console.ReadKey();

            M3 myM3 = new M3(260, "red", "turbo");
            myM3.Repair();
        }
    }
}