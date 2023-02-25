using BlazorCar.Shared;
using System.Net.Http.Json;

namespace BlazorCar.Client.Services.CarService
{
    public class CarService : ICarService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        //implementing the interface
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarService(HttpClient http) { 
            _http = http; 
        }

        // loading a list of cars from the server using HTTPGET request
        // categoryUrl is used to filter the list of cars by their categoryId
        public async Task LoadCars(string categoryUrl = null)
        {
            //if we are not providing a specific categoryUrl - we will retrieve all of the cars from the server
            if (categoryUrl == null)
            {
                Cars = await _http.GetFromJsonAsync<List<Car>>($"api/Car");
            }
            //if we do provide a specific categoryUrl - retrieve the cars that are in that category
            else
            {
                Cars = await _http.GetFromJsonAsync<List<Car>>($"api/Car/Category/{categoryUrl}");
            }            
            OnChange.Invoke();
        }

        // returning a Car object retrieved from the server from the use of a HTTPGET request of the car with the specified {id}
        public async Task<Car> GetCar(int id)
        {
            //calling GetFromJsonAsync method to send a HTTPGET request to the server
            //URL for the get request is "api/Car/{id}"
            return await _http.GetFromJsonAsync<Car>($"api/Car/{id}");
        }
    }
}

