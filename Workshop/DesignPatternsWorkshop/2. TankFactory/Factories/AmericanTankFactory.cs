using TankFactory.Units;
using TankManufacturer.Units;

namespace TankFactory.Factories
{
    public class AmericanTankFactory : ITankFactory
    {
        public ITank CreateTank()
        {
           return new Tank("M1 Abrams", 5.4, 120);
        }
    }
}
