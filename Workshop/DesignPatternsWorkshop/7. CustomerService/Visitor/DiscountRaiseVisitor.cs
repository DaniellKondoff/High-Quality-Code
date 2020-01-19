using CustomerService.Models;

namespace CustomerService.Visitor
{
    public class DiscountRaiseVisitor : ICustomerVisitor
    {
        private const double FivePercentDiscount = 5.0;
        public void Visit(Customer customer)
        {
            customer.RaiseDiscount(FivePercentDiscount);
        }
    }
}
