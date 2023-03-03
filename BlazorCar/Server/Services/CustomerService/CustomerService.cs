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
            /*var customer = new Customer
            {
                Forename = _Forename,
                Surname = _Surname,
                Email = _Email,
                PhoneNumber = _PhoneNumber
            };*/

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
