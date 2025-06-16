using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace RideOn.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        // Add EF DbContext, external services, etc
        return services;
    }
}
