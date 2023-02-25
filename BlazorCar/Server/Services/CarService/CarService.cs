using BlazorCar.Server.Data;
using BlazorCar.Server.Services.CategoryService;
using BlazorCar.Shared;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace BlazorCar.Server.Services.CarService
{
    //class method which is defining the methods used to retrieve Car data from the database
    public class CarService : ICarService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        //using the ICategoryService and DataContext objects as parameters used to get the cars/categories from the database
        public CarService(ICategoryService categoryService, DataContext context) 
        { 
                _categoryService = categoryService;
                _context = context;
        }
        
        //gets all cars from the database and returns a list of these cars
        public async Task<List<Car>> GetAllCars()
        {
            return await _context.Cars.ToListAsync();
        }

        //gets a single car with the id specified 
        public async Task<Car> GetCar(int id)
        {
            Car car = await _context.Cars.Include(c => c.Editions).FirstOrDefaultAsync(c => c.Id == id);
            return car;
        }

        //gets all the cars in the database that belong to the category specified with the categoryUrl
        public async Task<List<Car>> GetCarsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Cars.Where(c => c.CategoryId == category.Id).ToListAsync();
        }
        
    }
}
