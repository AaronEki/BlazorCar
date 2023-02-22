using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorCar.Shared;
using BlazorCar.Server.Services.CategoryService;

namespace BlazorCar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]

        //Asyncronous return type
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            // List of categories is moved from the client to the service
            return Ok(await _categoryService.GetCategories());            
        }
    }
}
