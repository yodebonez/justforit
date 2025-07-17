using JustforItEcommerce.Application.Interface;
using JustforItEcommerce.Infrastruture;
using JustforItEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace JustforItEcommerce.Application
{
	public class CartService : ICartService
	{
		private readonly DataContext _db;
		public CartService(DataContext db) => _db = db;

		public async Task<List<CartItem>> GetCartAsync() => await _db.CartItems.ToListAsync();
		public async Task AddToCartAsync(CartItem item)
		{
			_db.CartItems.Add(item);
			await _db.SaveChangesAsync();
		}
		public async Task RemoveFromCartAsync(int id)
		{
			var item = await _db.CartItems.FindAsync(id);
			if (item != null)
			{
				_db.CartItems.Remove(item);
				await _db.SaveChangesAsync();
			}
		}
	}
}
