using BlazorCar.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCar.Server.Data
{
    /*class to allow us to get our data onto the database using this alongside the dotnet ef migrations commands
    we can migrate the data that is held in this file to a new migrations file (dotnet ef migrations add <name>). This file can then be used
    to update the sqlexpress database with our categories and our cars (dotnet ef database update)*/
    public class DataContext : DbContext
    {        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        //setting the tables we will see in the database - Categories and Cars
        public DbSet<Category> Categories { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Building our categories in the database - with the data provied in the HasData funciton
            //this will create the categories listed here in the database
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hatchback", Url = "hatchback" },
                new Category { Id = 2, Name = "Estate", Url = "estate" },
                new Category { Id = 3, Name = "SUV", Url = "suv" },
                new Category { Id = 4, Name = "Coupe", Url = "coupe" },
                new Category { Id = 5, Name = "Specials", Url = "specials" }
                );
            //builing our cars in the database - the details provided below will be input into the database
            modelBuilder.Entity<Car>().HasData(
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
                    OriginalPrice = 13000,
                    DateCreated = new DateTime(2023, 1, 1)
                },
                new Car
                {
                    Id = 2,
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
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 5330,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 10650,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 44000,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 8000,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 41990,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 39460,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 123400,
                    DateCreated = new DateTime(2023, 1, 1)
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
                    OriginalPrice = 86000,
                    DateCreated = new DateTime(2023, 1, 1)
                }
                );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "No Warranty"},
                    new Edition { Id = 2, Name = "3 Month Warranty" },
                    new Edition { Id = 3, Name = "6 Month Warranty" },
                    new Edition { Id = 4, Name = "12 Month Warranty" }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("CarEdition").HasData(                    
                    new { EditionsId = 1, CarsId = 1 },
                    new { EditionsId = 2, CarsId = 1 },
                    new { EditionsId = 3, CarsId = 1 },
                    new { EditionsId = 4, CarsId = 1 },

                    new { EditionsId = 1, CarsId = 2 },

                    new { EditionsId = 1, CarsId = 3 },
                    new { EditionsId = 2, CarsId = 3 },
                    new { EditionsId = 3, CarsId = 3 },
                    new { EditionsId = 4, CarsId = 3 },

                    new { EditionsId = 1, CarsId = 4 },
                    new { EditionsId = 2, CarsId = 4 },
                    new { EditionsId = 3, CarsId = 4 },
                    new { EditionsId = 4, CarsId = 4 },

                    new { EditionsId = 1, CarsId = 5 },
                    new { EditionsId = 2, CarsId = 5 },
                    new { EditionsId = 3, CarsId = 5 },
                    new { EditionsId = 4, CarsId = 5 },

                    new { EditionsId = 1, CarsId = 6 },
                    new { EditionsId = 2, CarsId = 6 },
                    new { EditionsId = 3, CarsId = 6 },
                    new { EditionsId = 4, CarsId = 6 },

                    new { EditionsId = 1, CarsId = 7 },
                    new { EditionsId = 2, CarsId = 7 },
                    new { EditionsId = 3, CarsId = 7 },
                    new { EditionsId = 4, CarsId = 7 },

                    new { EditionsId = 1, CarsId = 8 },

                    new { EditionsId = 1, CarsId = 9 },
                    new { EditionsId = 2, CarsId = 9 },

                    new { EditionsId = 1, CarsId = 10 },
                    new { EditionsId = 2, CarsId = 10 },
                    new { EditionsId = 3, CarsId = 10 },
                    new { EditionsId = 4, CarsId = 10 }
                );
        }
    }
}
