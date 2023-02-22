using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CarService
{
    public interface ICarService
    {
        List<Car> Cars { get; set; }
        Task LoadCars();
    }
}
