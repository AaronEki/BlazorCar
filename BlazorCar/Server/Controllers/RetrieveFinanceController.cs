using BlazorCar.Server.Data;
using BlazorCar.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetrieveFinanceController : ControllerBase
    {   
        //used for getting data form the database! This is using the database in DataContext
        private readonly DataContext _dbContext;

        public RetrieveFinanceController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        //method to get the contects of the Customers table in the database and return this list
        public async Task<ActionResult<IEnumerable<Customer>>> RetrieveFinance()
        {
            return await _dbContext.Customers.ToListAsync();
        }
    }
}
