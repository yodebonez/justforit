using JustforItEcommerce.Models;

namespace JustforItEcommerce.Application.Interface
{
	public interface ICartService
	{
		Task<List<CartItem>> GetCartAsync();
		Task AddToCartAsync(CartItem item);
		Task RemoveFromCartAsync(int id);
	}
}
