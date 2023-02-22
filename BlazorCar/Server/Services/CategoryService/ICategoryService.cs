using BlazorCar.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCar.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
    }
}
