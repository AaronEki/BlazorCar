using BlazorCar.Shared;
using System.Xml.Linq;
using System;

namespace BlazorCar.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        //implementing the interface
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category> {
                new Category{ Id = 1, Name = "Hatchback", Url = "hatchback" },
                new Category{ Id = 2, Name = "Estate", Url = "estate" },
                new Category{ Id = 3, Name = "SUV", Url = "suv" },
                new Category{ Id = 4, Name = "Coupe", Url = "coupe" },
                new Category{ Id = 5, Name = "Specials", Url = "specials" }
            };
        }
    }
}
