using CustomerService.Models;

namespace CustomerService.Visitor
{
    public interface ICustomerVisitor
    {
        void Visit(Customer customer);
    }
}
