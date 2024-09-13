using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepairShop2.Data.Context;
using RepairShop2.Data.Repositories.Abstractions;
using RepairShop2.Data.Repositories.Concretes;
using RepairShop2.Data.UnitOfWorks;

namespace RepairShop2.Data.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
			services.AddDbContext<AppDbContex>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			return services;
		}

	}
}
