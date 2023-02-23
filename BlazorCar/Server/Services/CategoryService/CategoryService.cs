using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CategoryService
{
    //This service is used on the server side - this is becasue when you have potentially thousands of cars - you do not want the client to load every single one 
    public class CategoryService : ICategoryService
    {

        public List<Category> Categories { get; set; } = new List<Category> {
                new Category{ Id = 1, Name = "Hatchback", Url = "hatchback" },
                new Category{ Id = 2, Name = "Estate", Url = "estate" },
                new Category{ Id = 3, Name = "SUV", Url = "suv" },
                new Category{ Id = 4, Name = "Coupe", Url = "coupe" },
                new Category{ Id = 5, Name = "Specials", Url = "specials" }
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
