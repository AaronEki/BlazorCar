using BlazorCar.Server.Data;
using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        //declaring private field _dbContext as a reference of the DataContext class
        private readonly DataContext _dbContext;        

        public CustomerService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddCustomer(Customer customer)
        {          
            try
            {
                _dbContext.Customers.Add(customer);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }

        }                
    }
}
