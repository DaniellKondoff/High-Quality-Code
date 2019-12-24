using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            this.Balance = 2000;
        }
    }
}
