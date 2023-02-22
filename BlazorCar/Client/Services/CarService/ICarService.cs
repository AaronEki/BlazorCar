using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CarService
{
    public interface ICarService
    {
        public List<Car> Cars { get; set; }
        void LoadCars();
    }
}
