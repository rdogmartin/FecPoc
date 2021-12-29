using FecPoc.Core.Aggregates;
using FecPoc.Core.Dto;
using FecPoc.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace FecPoc.Infrastructure;

public class FecContext : DbContext
{
    public DbSet<PartnerDto> Partners => Set<PartnerDto>();

    public FecContext(DbContextOptions<FecContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dbPath = "C:\\Dev\\Playground\\FecPoc\\fecpoc.db";
        options.UseSqlite($"Data Source={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PartnerEntityTypeConfiguration());
    }
}
