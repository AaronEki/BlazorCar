using BlazorCar.Shared;

namespace BlazorCar.Server.Services.CarService
{
    public class CarService : ICarService
    {
        
        public async Task<List<Car>> GetAllCars()
        {
            return Cars;
        }

        public async Task<Car> GetCar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Car>> GetCarsByCategory(string categoryUrl)
        {
            throw new NotImplementedException();
        }
        public List<Car> Cars { get; set; } = new List<Car>{
                new Car
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Volvo V40 Hatchback 2015",
                    Description = "Volvo V40 1996cc 5dr",
                    Image = "/images/v40.jpg",
                    Mileage = "47,500",
                    Engine = "2.0L Diesel",
                    Gearbox = "Automatic",
                    Bodystyle = "Hatchback",
                    Colour = "Rebel Blue",
                    Doors = "5",
                    Price = 12579,
                    OriginalPrice = 13000
                },
                new Car
                {
                    Id= 2,
                    CategoryId = 5,
                    Title = "Toyota AE86 - 1987",
                    Description = "Iconic Panda Tureno AE86 - 1570cc 3dr - Perfect for Delivering Tofu Across Akina!",
                    Mileage = "92820",
                    Image = "/images/toyota-ae86.jpg",
                    Engine = "1.6L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "Hatchback",
                    Colour = "Panda",
                    Doors = "3",
                    Price = 26000,
                    OriginalPrice = 29000,
                },
                new Car
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Vauxhall Corsa Hatchback 2015",
                    Description = "Vauxhall Corsa 1160cc 3dr",
                    Mileage = "48,500",
                    Image = "/images/corsa.jpg",
                    Engine = "1.2L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "Hatchback",
                    Colour = "Blaze Red",
                    Doors = "3",
                    Price = 5325,
                    OriginalPrice = 5330
                },
                new Car
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Skoda Octavia Estate 2017",
                    Description = "Skoda Octavia 1570cc 5dr",
                    Mileage = "48,500",
                    Image = "/images/skoda-octavia-estate.jpg",
                    Engine = "1.6L Diesel",
                    Gearbox = "Automatic",
                    Bodystyle = "Estate",
                    Colour = "Corrida Red",
                    Doors = "5",
                    Price = 10650,
                    OriginalPrice = 10650
                },
                new Car
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "BMW 520d Estate 2023",
                    Description = "Skoda Octavia 2993cc 5dr",
                    Mileage = "11,200",
                    Image = "/images/bmw-520d.jpg",
                    Engine = "3.0L Diesel",
                    Gearbox = "Automatic",
                    Bodystyle = "Estate",
                    Colour = "Black",
                    Doors = "5",
                    Price = 43500,
                    OriginalPrice = 44000
                },
                new Car
                {
                    Id = 6,
                    CategoryId = 1,
                    Title = "Honda Civic Type R 1997",
                    Description = "Honda Civic Type R 182hp Hot Hatchback 1570cc 3dr",
                    Mileage = "170000",
                    Image = "/images/civic-1997.jpg",
                    Engine = "1.6L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "Hatchback",
                    Colour = "Black",
                    Doors = "3",
                    Price = 7000,
                    OriginalPrice = 8000
                },
                new Car
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Volvo XC40 2021",
                    Description = "1.5L T5 Pro Volvo XC40 1570cc 3dr",
                    Mileage = "170000",
                    Image = "/images/xc40.jpg",
                    Engine = "1.5L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "SUV",
                    Colour = "Grey",
                    Doors = "5",
                    Price = 41990,
                    OriginalPrice = 41990
                },
                new Car
                {
                    Id = 8,
                    CategoryId = 5,
                    Title = "Nissan Skyline GTR R34 2001",
                    Description = "Nissan R34 2.6L Twin-Turbocharged RB26 2606cc 3dr",
                    Mileage = "9000",
                    Image = "/images/r34-skyline.jpg",
                    Engine = "2.6L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "Coupe",
                    Colour = "Grey",
                    Doors = "3",
                    Price = 39460,
                    OriginalPrice = 39460
                },
                new Car
                {
                    Id = 9,
                    CategoryId = 4,
                    Title = "Porsche 718 Cayman GT4 RS 2022",
                    Description = "Porsche Cayman 718 GT4 RS Coupe 3997cc 3dr",
                    Mileage = "2500",
                    Image = "/images/porsche.jpg",
                    Engine = "4.0L Petrol",
                    Gearbox = "Automatic",
                    Bodystyle = "Coupe",
                    Colour = "Grey",
                    Doors = "3",
                    Price = 123400,
                    OriginalPrice = 123400
                },
                new Car
                {
                    Id = 10,
                    CategoryId = 4,
                    Title = "Honda NSX 1990",
                    Description = "Honda NSX 3.0L VTEC 2997cc 3dr",
                    Mileage = "2500",
                    Image = "/images/nsx.jpg",
                    Engine = "3.0L Petrol",
                    Gearbox = "Manual",
                    Bodystyle = "Coupe",
                    Colour = "Red",
                    Doors = "3",
                    Price = 84000,
                    OriginalPrice = 86000
                },
        };
    }
}
