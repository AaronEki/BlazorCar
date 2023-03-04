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

        [HttpPost]

        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            var result = await _customerService.AddCustomer(customer);

            if(result == false)
            {
                return StatusCode(500, "Error adding customer");
            }
            return Ok();
        }
        
    }
}
