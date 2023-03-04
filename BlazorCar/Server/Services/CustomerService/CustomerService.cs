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

        //method which returns a boolean and takes parameters object customer of type Customer (defined Customer.cs)
        public async Task<bool> AddCustomer(Customer customer)
        {          
            try
            {
                //adding to the customers table - the customer object passed as a parameter into this funciton
                _dbContext.Customers.Add(customer);
                //saving the changes to the db
                await _dbContext.SaveChangesAsync();

                //return true on success
                return true;
            }
            catch
            {
                //return false on fail
                return false;
            }

        }                
    }
}
