using FecPoc.Core.Dto;
using FecPoc.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace FecPoc.Infrastructure;

/// <inheritdoc />
public class FecContext : DbContext
{
    /// <summary>
    /// Represents the Partner table in the database.
    /// </summary>
    public DbSet<PartnerDto> Partners => Set<PartnerDto>();

    /// <summary>
    /// Initialize an instance of the class.
    /// </summary>
    /// <param name="options">Options for the database context.</param>
    public FecContext(DbContextOptions<FecContext> options) : base(options)
    {
    }

    /// <inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dbPath = "C:\\Dev\\Playground\\FecPoc\\fecpoc.db";
        options.UseSqlite($"Data Source={dbPath}");
    }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PartnerEntityTypeConfiguration());
    }
}
