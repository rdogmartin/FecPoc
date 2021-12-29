using System.ComponentModel.DataAnnotations;
using FecPoc.Common.Interfaces;
using FecPoc.Core.ValueObjects;

namespace FecPoc.Core.Dto
{
    /// <inheritdoc />
    public class PartnerDto: IDatabaseEntity
    {
        [MaxLength(47)]
        public Guid Id { get; set; }

        /// <summary>Gets or sets the partner's name.</summary>
        /// <remarks>
        /// Setting the property to null is the preferred way to configure a non-nullable property in EF Core.
        /// <see href="https://docs.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types">Working with Nullable Reference Types</see>
        /// </remarks>
        public PersonName Name { get; set; } = null!;
    }
}
