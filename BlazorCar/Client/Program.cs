using BlazorCar.Client;
using BlazorCar.Client.Services.CarService;
using BlazorCar.Client.Services.CartService;
using BlazorCar.Client.Services.CategoryService;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// dependency injection to register the CarSerivce
builder.Services.AddScoped<ICarService, CarService>();
// dependency injection to register the CategoryService
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<ICartService, CartService>();

// adding the package used to add the cars to the localstorage "cart"
builder.Services.AddBlazoredLocalStorage();
// used for pop up notifications when adding a car to the "cart"
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
