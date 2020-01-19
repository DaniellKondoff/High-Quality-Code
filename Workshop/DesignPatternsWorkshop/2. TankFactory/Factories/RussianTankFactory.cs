using TankFactory.Units;
using TankManufacturer.Units;

namespace TankFactory.Factories
{
    public class RussianTankFactory : ITankFactory
    {
        public ITank CreateTank()
        {
            return new Tank("T 34", 3.3, 75);
        }
    }
}
