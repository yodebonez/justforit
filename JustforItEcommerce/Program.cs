using JustforItEcommerce.Application.Interface;
using JustforItEcommerce.Application;
using System;
using JustforItEcommerce.Infrastruture;
using Microsoft.EntityFrameworkCore;

namespace JustforItEcommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

            builder.Services.AddControllers();

			builder.Services.AddDbContext<DataContext>(options =>
					  options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<ICartService, CartService>();

			var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
