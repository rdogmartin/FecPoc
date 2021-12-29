using FecPoc.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FecPoc.Core.Extensions;

/// <summary>
/// Contains extension methods.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Configures services defined in the Core project.
    /// </summary>
    /// <param name="services">The services used by the application.</param>
    /// <param name="config">The configuration for the application.</param>
    /// <returns>An <see cref="IServiceCollection" /> instance.</returns>
    public static IServiceCollection AddCoreConfig(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<PartnerDataService>();

        return services;
    }
}
