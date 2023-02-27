﻿using BlazorCar.Client.Services.CarService;
using BlazorCar.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;

namespace BlazorCar.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly ICarService _carService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService, ICarService carService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _carService = carService;
        }

        public async Task AddToCart(CarVariant carVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<CarVariant>>("cart");
            if (cart == null)
            {
                cart = new List<CarVariant>();
            }

            cart.Add(carVariant);
            await _localStorage.SetItemAsync("cart", cart);

            var car = await _carService.GetCar(carVariant.CarId);
            //showing a success message to the user
            _toastService.ShowSuccess(car.Title +  " Added to the cart!");
            // "refreshing" the number on the cart button
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<CarVariant>>("cart");

            if (cart == null)
            {
                return result;
            }

            foreach(var item in cart)
            {
                var car = await _carService.GetCar(item.CarId);
                var cartItem = new CartItem { CarId = car.Id ,
                                              CarTitle = car.Title,
                                              Image = car.Image,
                                              EditionId = item.EditionId
                };

                var variant = car.Variants.Find(variant => variant.EditionId == item.EditionId);
                if (variant != null)
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add(cartItem);
            }

            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CarVariant>>("cart");

            if (cart ==null)
            {
                return;
            }
            var cartItem = cart.Find(y => y.CarId == item.CarId && y.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
