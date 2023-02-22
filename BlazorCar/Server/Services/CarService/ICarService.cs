using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CarService
{
    public interface ICarService
    {
        Task<List<Car>> GetAllCars();
        Task<List<Car>> GetCarsByCategory(string categoryUrl);
        Task<Car> GetCar(int id);
    }
}
