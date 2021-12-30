using FecPoc.Core.ValueObjects;

namespace FecPoc.Core.Aggregates;

/// <summary>
/// Represents a partner in the CRM system.
/// </summary>
public class Partner
{
    /// <summary>Initializes an instance with the specified values.</summary>
    /// <param name="id">A value that uniquely identifies this partner.</param>
    /// <param name="name">The partner's name.</param>
    public Partner(Guid id, PersonName name)
    {
        Id = id;
        Name = name;
    }

    /// <summary>
    /// Gets or sets a value that uniquely identifies the partner.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the partner's name.
    /// </summary>
    public PersonName Name { get; set; }
}
