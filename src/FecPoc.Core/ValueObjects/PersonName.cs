namespace FecPoc.Core.ValueObjects;

/// <summary>
/// Represents a person's name.
/// </summary>
/// <param name="First">The person's first name.</param>
/// <param name="Last">The person's last name.</param>
public record class PersonName(string First, string Last);
