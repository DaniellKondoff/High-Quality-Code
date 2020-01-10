using System;

namespace _03Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulb = new Bulb();

            var turnOn = new TurnOn(bulb);
            var turnOff = new TurnOff(bulb);

            var remote = new RemoteControl();
            remote.Submit(turnOn); // Bulb has been lit!
            remote.Submit(turnOff); // Darkness!

            Console.ReadLine();
        }
    }
}
