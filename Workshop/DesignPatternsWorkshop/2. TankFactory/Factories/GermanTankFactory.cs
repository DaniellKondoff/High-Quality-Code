using TankFactory.Units;
using TankManufacturer.Units;

namespace TankFactory.Factories
{
    public class GermanTankFactory : ITankFactory
    {
        public ITank CreateTank()
        {
           return new Tank("Tiger", 4.5, 120);
        }
    }
}
