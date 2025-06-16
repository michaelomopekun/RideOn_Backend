using Microsoft.Extensions.DependencyInjection;


namespace RideOn.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register use cases, validators, etc
        return services;
    }
}
