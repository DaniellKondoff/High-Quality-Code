using _04.AbstractFactory.Factory;
using System;
using System.Reflection;

namespace _04.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = LoadFactory();

            PrintHeader("SPORTS CAR");
            var car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("LUXURY CAR");
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("ECONOMY CAR");
            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = "_04.AbstractFactory.Factory.BMWFactory";
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);
        }
    }
}
