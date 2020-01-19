using System.Collections.Generic;
using TankFactory.Units;

namespace TankFactory.Factories
{
    public class TankFactoryProvider
    {
        private static Dictionary<TankType, ITankFactory> factories;
        public static TankFactoryProvider InitFactories()
        {
            factories = new Dictionary<TankType, ITankFactory>();
            factories.Add(TankType.American, new AmericanTankFactory());
            factories.Add(TankType.German, new GermanTankFactory());
            factories.Add(TankType.Russian, new RussianTankFactory());

            return new TankFactoryProvider();
        }

        public static ITank CreateTank(TankType type)
        {
            return factories[type].CreateTank();
        }
    }
}
