using System.ComponentModel.DataAnnotations;

namespace FecPoc.Core
{
    public class Partner
    {
        public Guid Id { get; set; }

        /// <summary>Get's or sets the partner's name.</summary>
        /// <remarks>
        /// Setting the property to null is the preferred way to configure a non-nullable property in EF Core.
        /// See https://docs.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types
        /// </remarks>
        public PersonName Name { get; set; } = null!;
    }
}