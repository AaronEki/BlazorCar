﻿using BlazorCar.Client.Pages;
using BlazorCar.Client.Services.CarService;
using BlazorCar.Shared;
using Blazored.SessionStorage;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.Contracts;

namespace BlazorCar.Client.Services.CartService
{
    public class CartService : ICartService
    {
        //declaring private fields _localStorage, _toastService and _carService
        private readonly ISessionStorageService _sessionStorage;
        private readonly IToastService _toastService;
        private readonly ICarService _carService;

        //These 2 private fields are used to check if the user is authenticated (logged in)
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authStateProvider;

        //declaring the OnChange event
        public event Action OnChange;

        //assigning the parameters to the services
        public CartService(ISessionStorageService localStorage, IToastService toastService, ICarService carService,
            HttpClient httpClient, AuthenticationStateProvider authStateProvider)
        {
            _sessionStorage = localStorage;
            _toastService = toastService;
            _carService = carService;
            _httpClient = httpClient;
            _authStateProvider = authStateProvider;
        }            

        //declaring the AddToCart function
        public async Task AddToCart(CarVariant carVariant)
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            //populating a list cart with the items in the cart list in localstorage
            var cart = await _sessionStorage.GetItemAsync<List<CarVariant>>("cart");

            if (authState.User.IsInRole("Administrator"))
            {
                _toastService.ShowError("Admin users cannot add cars to the payment cart!");
                return;
            }

            //If the user is logged in - we will continue and add the car to the payment cart
            //However if the user is not logged in we will 
            if (authState.User.Identity.IsAuthenticated)
            {                
                //if the cart is empty then create a new empty cart list of CarVariants
                if (cart == null)
                {
                    cart = new List<CarVariant>();
                }
                // if the number of cars in the cart is greater than 0 - then we will show an error and return from the function
                // there should only be 1 car per transaction
                else if (cart.Count > 0)
                {
                    _toastService.ShowError("There is already a car in the payment cart, complete the transaction or remove the car before adding another car to the cart");
                    return;
                }
            }
            else
            {
                _toastService.ShowError("Please login to a user account before adding an item to the cart!");
                return;
            }
            
            // we add the carVariant to the list of cars
            cart.Add(carVariant);
            await _sessionStorage.SetItemAsync("cart", cart);
            //we use the GetCar method so we can add the correct car to the list
            var car = await _carService.GetCar(carVariant.CarId);
            //showing a success message to the user
            _toastService.ShowSuccess(car.Title +  " Added to the cart!");
            // "refreshing" the number on the cart button
            OnChange.Invoke();
        }

        //retrieving items from the cart to display for the user
        public async Task<List<CartItem>> GetCartItems()
        {
            //we are creating a new list result
            var result = new List<CartItem>();
            // taking the items from the localstorage and storing them into cart
            var cart = await _sessionStorage.GetItemAsync<List<CarVariant>>("cart");

            //if cart is empty we return an empty list
            if (cart == null)
            {
                return result;
            }
            //for each cart item
            foreach(var item in cart)
            {
                //get the car details for the car item
                var car = await _carService.GetCar(item.CarId);
                var cartItem = new CartItem { CarId = car.Id ,
                                              CarTitle = car.Title,
                                              Image = car.Image,
                                              EditionId = item.EditionId
                };
                //find the variant of the car that has been added to the cart
                var variant = car.Variants.Find(variant => variant.EditionId == item.EditionId);
                //if the variant is not empty we set the name and the price to be that of the correct variant
                if (variant != null)
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }
                //we then add the cartItem to the result
                result.Add(cartItem);
            }
            //finally return the result list
            return result;
        }
        
        //function to delete an item from the cart
        public async Task DeleteItem(CartItem item)
        {
            //getting the list from localstorage
            var cart = await _sessionStorage.GetItemAsync<List<CarVariant>>("cart");
            // if the cart is empty we return and exit
            if (cart ==null)
            {
                return;
            }
            // otherwise we will find the correct car and remove it from the list
            var cartItem = cart.Find(y => y.CarId == item.CarId && y.EditionId == item.EditionId);
            cart.Remove(cartItem);
            //we then update the cart list and update the page
            await _sessionStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        //function to clear the cart
        public async Task clearCart()
        {
            //getting the list from localstorage
            var cart = await _sessionStorage.GetItemAsync<List<CarVariant>>("cart");
            cart.Clear();
            await _sessionStorage.RemoveItemAsync("cart");
            _toastService.ShowSuccess("Transaction request has been sent!");
            OnChange.Invoke();
        }
    }
}
