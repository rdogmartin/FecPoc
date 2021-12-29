using FecPoc.Core.ValueObjects;

namespace FecPoc.Core.Aggregates;

public class Partner
{
    public Guid Id { get; set; }

    /// <summary>Gets or sets the partner's name.</summary>
    public PersonName Name { get; set; } = null!;
}
