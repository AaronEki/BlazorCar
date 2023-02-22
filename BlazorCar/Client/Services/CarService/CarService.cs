using BlazorCar.Shared;
using System.Net.Http.Json;

namespace BlazorCar.Client.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly HttpClient _http;

        //implementing the interface
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarService(HttpClient http) { 
            _http = http; 
        }
        public async Task LoadCars()
        {
            Cars = await _http.GetFromJsonAsync<List<Car>>("api/Car");
        }
    }
}

