using BlazorCar.Server.Data;
using BlazorCar.Shared;
using Microsoft.EntityFrameworkCore;

//based on the CategoryService provided by (PatrickGod, 2020)
namespace BlazorCar.Server.Services.CategoryService
{
    //This service is used on the server side - this is becasue when you have potentially thousands of cars - you do not want the client to load every single one 
    public class CategoryService : ICategoryService
    {        
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
