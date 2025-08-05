using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Application.Services;
using Warehouse.Application.Interfaces;

namespace Warehouse.Application.Configurations;

public static class ConfigureService
{
    public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IResourceService, ResourceService>();
    }
}
