using System;

namespace _04.AbstractFactory.Models.BMW
{
    public abstract class BMWBase : IAutomobile
    {
        public abstract string Name { get; }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is off.");
        }
    }
}
