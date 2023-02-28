using CoreWeb.Data.Models;

namespace CoreWeb.Interface.Services
{
    public interface ICustomerService
    {
        Customer GetCustomer(Guid customerId);
    }
}
