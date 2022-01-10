using FecPoc.Core.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FecPoc.Infrastructure.Config;

/// <summary>
/// Specifies configuration for the <see cref="PartnerDto" /> database entity.
/// </summary>
public class PartnerEntityTypeConfiguration : IEntityTypeConfiguration<PartnerDto>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<PartnerDto> builder)
    {
        // To configure Name as a value object, we could just say this: builder.OwnsOne(p => p.Name);
        // But then the columns that get created are called Name_First and Name_Last.
        // To control the column names, use HasColumnName.
        builder.OwnsOne(p => p.Name).Property(p => p.First)
            .HasColumnName("FirstName")
            .HasMaxLength(50); // Doesn't work to put MaxLength attribute on this property in the record, so we do so here.

        builder.OwnsOne(p => p.Name).Property(p => p.Last)
            .HasColumnName("LastName")
            .HasMaxLength(50);
    }
}
