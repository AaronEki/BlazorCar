using BlazorCar.Server.Data;
using BlazorCar.Server.Services.CarService;
using BlazorCar.Server.Services.CategoryService;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
/*
 For this website to function properly - it is important that sqlexpress is installed on the system

there are various NuGet packages used in this program. I will list the packagages and version numbers of these used in the creation of the site here:

Microsoft.AspNetCore.Components.WebAssembly.Server 6.0.13   (version is important here, the website can potentially not function as intended if this version is not used)
Microsoft.EntityFrameworkCore 7.03
Microsoft.EntityFrameworkCore.Design 7.03
Microsoft.EntityFrameworkCore.SqlServer 7.03

it is also worth ensuring you have dotnet ef tools installed in your NuGet Package manager:
This will be used when migrating the data stored in the DataContext.cs file to the database
 */



// Add services to the container.

//registering our datacontext for use with the database
builder.Services.AddDbContext<DataContext>(options =>
{
    //Configuration allows us to access the config in the appsetting.json file
    //allowing us to use the sqlserver with the default connectino specified in appsettings.json
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICarService, CarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
