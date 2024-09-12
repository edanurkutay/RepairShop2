using Microsoft.EntityFrameworkCore;
using RepairShop2.Data.Mappings;
using RepairShop2.Entity.Entities;
using System.Reflection;


namespace RepairShop2.Data.Context
{
	public class AppDbContex : DbContext
	{
		protected AppDbContex()
		{

		}
		public AppDbContex(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Staff>staffs { get; set; }
		public DbSet<Customer> customers { get; set; }
		public DbSet<Fault>faults { get; set; }
		public DbSet<Bill>bills { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

	}
}
