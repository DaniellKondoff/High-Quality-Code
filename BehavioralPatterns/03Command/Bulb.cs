using System;

namespace _03Command
{
    // Receiver
    public class Bulb
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb has been lit");
        }

        public void TurnOff()
        {
            Console.WriteLine("Darkness!");
        }
    }
}
