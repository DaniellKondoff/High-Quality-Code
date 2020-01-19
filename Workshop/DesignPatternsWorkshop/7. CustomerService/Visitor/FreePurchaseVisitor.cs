using CustomerService.Models;

namespace CustomerService.Visitor
{
    public class FreePurchaseVisitor : ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.AddFreePurchase(new Purchase("SteamOp", 0.0));
        }
    }
}
