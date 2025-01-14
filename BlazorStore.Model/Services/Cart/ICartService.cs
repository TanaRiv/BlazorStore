using BlazorStore.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorStore.Model.Services.Cart
{
    public interface ICartService
    {
        Task<List<CartItem>> GetCartItemsAsync();
        Task AddToCartAsync(CartItem item);
        Task SaveCartItemsAsync(List<CartItem> items);
        Task<int> GetCartItemCountAsync();
    }
}
