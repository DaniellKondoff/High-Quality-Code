using _02.SimpleFactory.Interfaces;
using System;

namespace _02.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FanFactory fanFactory = new FanFactory();
            IFan ceilingFan = fanFactory.CreateFan(FanType.CeilingFan);
            IFan tableFan = fanFactory.CreateFan(FanType.TableFan);

            ceilingFan.SwitchOn();
            tableFan.SwitchOff();

            Console.WriteLine(ceilingFan.GetState());
            Console.WriteLine(tableFan.GetState());
        }
    }
}
