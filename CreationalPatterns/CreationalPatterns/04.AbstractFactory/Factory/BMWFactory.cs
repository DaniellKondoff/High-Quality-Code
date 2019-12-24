using _04.AbstractFactory.Models;
using _04.AbstractFactory.Models.BMW;

namespace _04.AbstractFactory.Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}
