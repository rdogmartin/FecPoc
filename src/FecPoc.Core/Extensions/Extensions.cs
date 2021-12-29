using FecPoc.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FecPoc.Core.Extensions;

public static class Extensions
{
    public static IServiceCollection AddCoreConfig(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<PartnerService>();

        return services;
    }
}