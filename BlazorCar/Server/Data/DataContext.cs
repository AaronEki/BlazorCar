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
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarVariant>().HasKey( c => new { c.CarId, c.EditionId });


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
                    DateCreated = new DateTime(2023, 1, 1)
                }
                );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "No Warranty"},
                    new Edition { Id = 2, Name = "3 Month Warranty" },
                    new Edition { Id = 3, Name = "6 Month Warranty" },
                    new Edition { Id = 4, Name = "12 Month Warranty" }
                );

            modelBuilder.Entity<CarVariant>().HasData(
                    // car 1
                    new CarVariant 
                    { 
                        CarId = 1,
                        EditionId = 1,
                        Price = 12599,
                        OriginalPrice = 12750,
                    },
                    new CarVariant
                    {
                        CarId = 1,
                        EditionId = 2,
                        Price = 12749,
                        OriginalPrice = 12999,
                    },
                    new CarVariant
                    {
                        CarId = 1,
                        EditionId = 3,
                        Price = 12899,
                        OriginalPrice = 13149,
                    },
                    new CarVariant
                    {
                        CarId = 1,
                        EditionId = 4,
                        Price = 13049,
                        OriginalPrice = 13299,
                    },
                    // car 2
                    new CarVariant
                    {
                        CarId = 2,
                        EditionId = 1,
                        Price = 25000,
                        OriginalPrice = 25250,
                    },
                    // car 3
                    new CarVariant
                    {
                        CarId = 3,
                        EditionId = 1,
                        Price = 5150,
                        OriginalPrice = 5400,
                    },
                    new CarVariant
                    {
                        CarId = 3,
                        EditionId = 2,
                        Price = 5300,
                        OriginalPrice = 5550,
                    },
                    new CarVariant
                    {
                        CarId = 3,
                        EditionId = 3,
                        Price = 5450,
                        OriginalPrice = 5700,
                    },
                    new CarVariant
                    {
                        CarId = 3,
                        EditionId = 4,
                        Price = 5600,
                        OriginalPrice = 5850,
                    },
                    // car 4
                    new CarVariant
                    {
                        CarId = 4,
                        EditionId = 1,
                        Price = 9000,
                        OriginalPrice = 9000,
                    },
                    new CarVariant
                    {
                        CarId = 4,
                        EditionId = 2,
                        Price = 9150,
                        OriginalPrice = 9150,
                    },
                    new CarVariant
                    {
                        CarId = 4,
                        EditionId = 3,
                        Price = 9300,
                        OriginalPrice = 9300,
                    },
                    new CarVariant
                    {
                        CarId = 4,
                        EditionId = 4,
                        Price = 9450,
                        OriginalPrice = 9450,
                    },
                    // car 5
                    new CarVariant
                    {
                        CarId = 5,
                        EditionId = 1,
                        Price = 43500,
                        OriginalPrice = 43500,
                    },
                    new CarVariant
                    {
                        CarId = 5,
                        EditionId = 2,
                        Price = 43650,
                        OriginalPrice = 43650,
                    },
                    new CarVariant
                    {
                        CarId = 5,
                        EditionId = 3,
                        Price = 43800,
                        OriginalPrice = 43800,
                    },
                    new CarVariant
                    {
                        CarId = 5,
                        EditionId = 4,
                        Price = 43950,
                        OriginalPrice = 43950,
                    },
                    // car 6
                    new CarVariant
                    {
                        CarId = 6,
                        EditionId = 1,
                        Price = 7000,
                        OriginalPrice = 7500,
                    },
                    // car 7
                    new CarVariant
                    {
                        CarId = 7,
                        EditionId = 1,
                        Price = 47000,
                        OriginalPrice = 47500,
                    },
                    // car 8
                    new CarVariant
                    {
                        CarId = 8,
                        EditionId = 1,
                        Price = 39500,
                        OriginalPrice = 39600,
                    },
                    // car 9
                    new CarVariant
                    {
                        CarId = 9,
                        EditionId = 1,
                        Price = 125000,
                        OriginalPrice = 125000,
                    },
                    new CarVariant
                    {
                        CarId = 9,
                        EditionId = 2,
                        Price = 126000,
                        OriginalPrice = 126000,
                    },
                    new CarVariant
                    {
                        CarId = 9,
                        EditionId = 3,
                        Price = 127000,
                        OriginalPrice = 127000,
                    },
                    //car 10
                    new CarVariant
                    {
                        CarId = 10,
                        EditionId = 1,
                        Price = 87000,
                        OriginalPrice = 87000,
                    },
                    new CarVariant
                    {
                        CarId = 10,
                        EditionId = 4,
                        Price = 90000,
                        OriginalPrice = 90000,
                    }
                );
            
        }
    }
}
