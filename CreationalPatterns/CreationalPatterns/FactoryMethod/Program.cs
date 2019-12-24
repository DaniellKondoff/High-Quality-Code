using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var cityAcct = factory.GetSavingsAccount("CITY-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citu balance is ${cityAcct.Balance} and national balance is ${nationalAcct.Balance}");
        }
    }
}
