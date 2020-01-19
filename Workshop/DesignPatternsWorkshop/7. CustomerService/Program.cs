namespace CustomerService
{
    using CustomerService.Data;
    using CustomerService.Models;
    using CustomerService.Visitor;

    public class Program
    {
        static void Main()
        {
            var repository = new CustomerRepository();

            var premiumCustomers = repository.GetPremiumCustomers();

            DiscountRaiseVisitor discountRaiseVisitor = new DiscountRaiseVisitor();
            foreach (var premiumCustomer in premiumCustomers)
            {
                premiumCustomer.Accept(discountRaiseVisitor);
            }

            FreePurchaseVisitor freePurchaseVisitor = new FreePurchaseVisitor();
            var allCustomers = repository.GetAll();
            foreach (var customer in allCustomers)
            {
                customer.Accept(freePurchaseVisitor);
            }
        }
    }
}
