using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepairShop2.Service.Services.Abstractions;
using RepairShop2.Service.Services.Concrete;

namespace RepairShop2.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
            public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
            {
                services.AddScoped<IFaultService, FaultService>();
                return services;
            }
    }
}
