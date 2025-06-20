using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RideOn.Infrastructure.Data;
using RideOn.Infrastructure.Exceptions;
using DotNetEnv;
// using RideOn.Infrastructure.Exceptions;


namespace RideOn.Infrastructure;

#region 
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {

        Env.Load();

        static string GetEnv(string key) => Environment.GetEnvironmentVariable(key) ?? throw new EnvVarNotSetException(key);

        services.AddDbContext<RideOnDbContext>(options =>
        {
            var connectionString = $"Server={GetEnv("POSTGRES_HOST")};" +
                                    $"Port={GetEnv("POSTGRES_PORT")};" +
                                    $"Database={GetEnv("POSTGRES_DB")};" +
                                    $"Username={GetEnv("POSTGRES_USER")};" +
                                    $"Password={GetEnv("POSTGRES_PASSWORD")};" +
                                    $"SSL Mode={GetEnv("POSTGRES_SSLMODE")};Trust Server Certificate=true";

            options.UseNpgsql(connectionString);

        });

        return services;
    }
}
#endregion
