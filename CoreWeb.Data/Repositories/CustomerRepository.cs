using CoreWeb.Data.IRepositories;
using CoreWeb.Data.Models;

namespace CoreWeb.Data.Repositories
{
    public class CustomerRepository: BaseRepository, ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Customer? GetCustomer(Guid CustomerId)
        {
            return _db.Customers.Where(x => x.Id == CustomerId).FirstOrDefault();
        }
    }
}
