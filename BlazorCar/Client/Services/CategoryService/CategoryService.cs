using BlazorCar.Shared;
using System.Xml.Linq;
using System;
using System.Runtime.CompilerServices;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorCar.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        //create and assign the field http
        private readonly HttpClient _http;

        //implementing the interface
        public List<Category> Categories { get; set; } = new List<Category>();

        //web service call (requires injecting the http client class)
        //constructor to inject the http client class - to be able to make the http call
        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task  LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}
