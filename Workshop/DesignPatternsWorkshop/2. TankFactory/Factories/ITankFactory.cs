using TankFactory.Units;

namespace TankFactory.Factories
{
    public interface ITankFactory
    {
        ITank CreateTank();
    }
}
