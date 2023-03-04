using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<bool> AddCustomer(Customer customer);
        //Task<Customer> GetCustomer(string Forename, string Surname, string EmailAddress, string PhoneNumber);
    }
}
