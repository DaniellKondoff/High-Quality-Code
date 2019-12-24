using FactoryMethod.Interfaces;
using FactoryMethod.Models;
using System;

namespace FactoryMethod
{
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITY"))
            {
                return new CitySavingsAcct();
            }

            if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingsAcct();
            }

            throw new ArgumentException("Invalid Account Number");
        }
    }
}
