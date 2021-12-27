using FecPoc.Core;
using FecPoc.Core.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FecPoc.Infrastructure.Config
{
    public class PartnerEntityTypeConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            // To configure Name as a value object, we could just say this: builder.OwnsOne(p => p.Name);
            // But then the columns that get created are called Name_First and Name_Last.
            // To control the column names, use HasColumnName.
            builder.OwnsOne(p => p.Name).Property(p => p.First)
                .HasColumnName("FirstName")
                .HasMaxLength(50);
            
            builder.OwnsOne(p => p.Name).Property(p => p.Last)
                .HasColumnName("LastName")
                .HasMaxLength(50);
        }
    }
}
