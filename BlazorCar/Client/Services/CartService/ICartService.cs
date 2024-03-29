﻿using BlazorCar.Shared;

namespace BlazorCar.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CarVariant carVariant);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);

        Task clearCart();
    }
}
