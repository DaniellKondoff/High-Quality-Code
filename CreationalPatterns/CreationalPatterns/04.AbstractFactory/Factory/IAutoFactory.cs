using _04.AbstractFactory.Models;

namespace _04.AbstractFactory.Factory
{
    public interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEconomyCar();
    }
}
