using Inheritance;

namespace C_sharp_advanced
{
    public class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenToTheRadio();

            TV newTv = new TV(false, "Samsung");
            newTv.SwitchOn();
            newTv.WatchingTv();
        }
    }
}
