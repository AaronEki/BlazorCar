using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CarService
{
    public interface ICarService
    {
        //event callback implementation
        event Action OnChange;
        List<Car> Cars { get; set; }
        Task LoadCars(string categoryUrl = null);

        Task<Car> GetCar(int id);
    }
}
