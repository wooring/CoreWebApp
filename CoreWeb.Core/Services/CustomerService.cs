using CoreWeb.Data.IRepositories;
using CoreWeb.Data.Models;
using CoreWeb.Interface.Services;

namespace CoreWeb.Core.Services
{
    public class CustomerService: ICustomerService
    {
        private ICustomerRepository _customerRepo;
        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public Customer GetCustomer(Guid customerId) 
        {
            return _customerRepo.GetCustomer(customerId);
        }
    }
}
