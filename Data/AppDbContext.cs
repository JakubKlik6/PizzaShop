using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
	}
}
