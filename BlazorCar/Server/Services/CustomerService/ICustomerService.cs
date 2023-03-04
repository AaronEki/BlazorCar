using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<bool> AddCustomer(Customer customer);        
    }
}
