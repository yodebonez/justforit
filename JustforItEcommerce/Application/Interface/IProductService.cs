using JustforItEcommerce.Models;

namespace JustforItEcommerce.Application.Interface
{
	public interface IProductService
	{
		Task<List<Product>> GetProductsAsync();
	}
}
