﻿using FecPoc.Core.Interfaces;
using FecPoc.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FecPoc.Infrastructure.Extensions;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureConfig(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<FecContext>();

        // services.AddScoped<IRepository<PartnerDto>, Repository<PartnerDto>>();
        services.AddScoped<IPartnerRepository, PartnerRepository> ();

        return services;
    }
}
