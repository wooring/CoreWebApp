using CoreWeb.Data.Models;

namespace CoreWeb.Data.IRepositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(Guid CustomerId);
    }
}
