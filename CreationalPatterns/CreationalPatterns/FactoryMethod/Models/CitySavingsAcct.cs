using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class CitySavingsAcct : ISavingsAccount
    {
        public CitySavingsAcct()
        {
            this.Balance = 5000;
        }
    }
}
