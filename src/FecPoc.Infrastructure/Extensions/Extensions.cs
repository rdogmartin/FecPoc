using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;
using FecPoc.Core.Dto;
using FecPoc.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FecPoc.Infrastructure.Extensions;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureConfig(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<FecContext>();

        services.AddScoped<IRepository<PartnerDto>, Repository<PartnerDto>>();

        return services;
    }
}
