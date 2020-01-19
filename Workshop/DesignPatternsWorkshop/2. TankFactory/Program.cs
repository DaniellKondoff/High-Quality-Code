namespace TankManufacturer
{
    using System;
    using TankFactory;
    using TankFactory.Factories;

    class Program
    {
        static void Main()
        {
            var factories = TankFactoryProvider.InitFactories();

            var americanTank = TankFactoryProvider.CreateTank(TankType.American);
            Console.WriteLine(americanTank);

            var germanTank = TankFactoryProvider.CreateTank(TankType.German);
            Console.WriteLine(germanTank);

            var russianTank = TankFactoryProvider.CreateTank(TankType.Russian);
            Console.WriteLine(russianTank);

        }
    }
}
