using JustforItEcommerce.Application.Interface;
using JustforItEcommerce.Infrastruture;
using JustforItEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JustforItEcommerce.Application
{


	public class ProductService : IProductService
	{
		private readonly DataContext _db;
		public ProductService(DataContext db) => _db = db;

		public async Task<List<Product>> GetProductsAsync() => await _db.Products.ToListAsync();
	}

}
