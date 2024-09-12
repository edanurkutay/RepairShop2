using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepairShop2.Data.Repositories.Abstractions;
using RepairShop2.Data.Repositories.Concretes;

namespace RepairShop2.Data.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
			return services;
		}

	}
}
