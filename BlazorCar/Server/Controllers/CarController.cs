using BlazorCar.Server.Services.CarService;
using BlazorCar.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService) { 
            this._carService= carService;
        }

        [HttpGet]

        public async Task<ActionResult<List<Car>>> GetAllCars()
        {
            return Ok(await _carService.GetAllCars());
        }
    }
}
