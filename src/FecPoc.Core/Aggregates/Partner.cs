using FecPoc.Core.ValueObjects;

namespace FecPoc.Core.Aggregates;

public class Partner
{
    public Partner(Guid id, PersonName name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; set; }

    /// <summary>Gets or sets the partner's name.</summary>
    public PersonName Name { get; set; }
}
