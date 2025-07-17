using JustforItEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace JustforItEcommerce.Infrastruture
{
	public class DataContext : DbContext
	{


		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Product> Products { get; set; }
		public DbSet<CartItem> CartItems { get; set; }


	}
}
