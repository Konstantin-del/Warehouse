using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence;

public static class ConfigureRepository
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? Environment.GetEnvironmentVariable("DATABASE_CONNECTION");

        services.AddDbContext<Context>(
            options => options.UseNpgsql(connectionString));

        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
}
