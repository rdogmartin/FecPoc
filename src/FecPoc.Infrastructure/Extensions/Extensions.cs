using FecPoc.Core.Interfaces;
using FecPoc.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FecPoc.Infrastructure.Extensions;

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
    /// <param name="env">A string representing the deployment environment. Examples: Development, Staging, Production</param>
    /// <returns>An <see cref="IServiceCollection" /> instance.</returns>
    public static IServiceCollection AddInfrastructureConfig(this IServiceCollection services, IConfiguration config, string env)
    {
        services.AddDbContext<FecContext>(
            cfg =>
            {
                // Log retries. Test to see if this is really needed. Specify a non-existent DB in the connection string to trigger a 4060 error (which is considered retryable).
                // From https://stackoverflow.com/questions/67929372/
                // See https://github.com/dotnet/efcore/blob/main/src/EFCore.SqlServer/Storage/Internal/SqlServerTransientExceptionDetector.cs for all retryable errors
                cfg.LogTo(
                    filter: (eventId, level) => eventId.Id == CoreEventId.ExecutionStrategyRetrying,
                    logger: (eventData) =>
                    {
                        var retryEventData = eventData as ExecutionStrategyEventData;
                        var exceptions = retryEventData?.ExceptionsEncountered;
                        if (exceptions != null)
                        {
                            Console.WriteLine($"Retry #{exceptions.Count} with delay {retryEventData?.Delay} due to error: {exceptions.Last().Message}");
                        }
                    });

                cfg.EnableSensitiveDataLogging();

                if (env != "Production") {
                    // There's a perf cost to this so let's do it only in lower environments
                    cfg.EnableDetailedErrors();
                }
            }
            );

        // services.AddScoped<IRepository<PartnerDto>, Repository<PartnerDto>>();
        services.AddScoped<IPartnerRepository, PartnerRepository> ();

        return services;
    }
}
