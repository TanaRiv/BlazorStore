using BlazorStore.Model.Data;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorStore.Model.Services.Cart
{
    public class CartService : ICartService
    {
        private const string CartSessionKey = "CartItems";
        private readonly IJSRuntime _jsRuntime;

        public CartService(IJSRuntime jsruntinme)
        {
            _jsRuntime = jsruntinme;
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", CartSessionKey);
            return string.IsNullOrEmpty(json) ? new List<CartItem>() : JsonSerializer.Deserialize<List<CartItem>>(json);

        }
        public async Task AddToCartAsync(CartItem item)
        {
            var items = await GetCartItemsAsync();
            items.Add(item);
            await SaveCartItemsAsync(items);
        }

        public async Task SaveCartItemsAsync(List<CartItem> items)
        {
            var json = JsonSerializer.Serialize(items);
            await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", CartSessionKey, json);
        }

        public async Task<int> GetCartItemCountAsync()
        {
            var items = await GetCartItemsAsync();
            return items.Count;
        }

      
    }

}
