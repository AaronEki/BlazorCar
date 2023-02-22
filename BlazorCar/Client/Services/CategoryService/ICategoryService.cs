using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        //Task return type to allow us to use an aynchronous method
        Task LoadCategories();
    }
}
