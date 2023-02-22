using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
