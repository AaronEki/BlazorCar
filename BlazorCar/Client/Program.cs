using BlazorCar.Client;
using BlazorCar.Client.Services.CarService;
using BlazorCar.Client.Services.CategoryService;
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

await builder.Build().RunAsync();
