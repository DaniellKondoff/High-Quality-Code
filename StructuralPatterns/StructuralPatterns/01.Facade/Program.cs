using System;

namespace _01.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine();
            Console.WriteLine(customer.Name +" has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
