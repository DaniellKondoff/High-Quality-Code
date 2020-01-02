using System;

namespace _01.Facade
{
    class Mortgage
    {
        private Bank _bank;
        private Loan _loan;
        private Credit _credit;

        public Mortgage()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
        }

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan", cust.Name, amount);
            Console.WriteLine();

            bool eligible = true;

            // Check creditworthyness of applicant

            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}