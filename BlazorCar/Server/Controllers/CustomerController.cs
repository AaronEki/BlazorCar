using BlazorCar.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorCar.Server.Services.CustomerService;

namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        //httppost as we want to add the details supplied by the customer to the database
        [HttpPost]

        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            //setting result to be the return value of the AddCustomer method when supplied the parameter customer
            bool result = await _customerService.AddCustomer(customer);

            //if not sucessful return this statuscode
            if(result == false)
            {
                return StatusCode(500, "Error adding customer");
            }
            //else return ok
            return Ok();
        }
        
    }
}
