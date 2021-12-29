using System;
using FecPoc.Core.Aggregates;
using FecPoc.Core.ValueObjects;

namespace FecPoc.UnitTests.Builders;

/// <summary>
/// A utility class for building mock partner data. Use <see cref="MockPartnerBuilder.Get" /> to create an instance, then optionally override
/// default values using the WithXXX methods. Finally call <see cref="ToPartner" /> to generate a <see cref="Partner" /> instance.
/// </summary>
public class MockPartnerBuilder
{
    private Guid _id;
    private PersonName _name;

    private MockPartnerBuilder()
    {
        _id = Guid.NewGuid();
        _name = new PersonName("Bob", "Dylan");
    }

    /// <summary>
    /// Retrieves a builder instance with default values. Call <see cref="ToPartner" /> to generate a <see cref="Partner" /> instance.
    /// </summary>
    /// <returns>A <see cref="MockPartnerBuilder" /> instance</returns>
    public static MockPartnerBuilder Get()
    {
        return new MockPartnerBuilder();
    }

    /// <summary>
    /// Updates the instance with the specified <paramref name="id" />.
    /// </summary>
    /// <param name="id">The ID to assign to this instance.</param>
    /// <returns>A <see cref="MockPartnerBuilder" /> instance</returns>
    public MockPartnerBuilder WithId(Guid id)
    {
        _id = id;
        return this;
    }

    /// <summary>
    /// Updates the instance with the specified <paramref name="name" />.
    /// </summary>
    /// <param name="name">The name to assign to this instance.</param>
    /// <returns>A <see cref="MockPartnerBuilder" /> instance</returns>
    public MockPartnerBuilder WithName(PersonName name)
    {
        _name = name;
        return this;
    }

    /// <summary>
    /// Generates a <see cref="Partner" /> instance.
    /// </summary>
    /// <returns>A <see cref="Partner" /> instance</returns>
    public Partner ToPartner()
    {
        return new Partner(_id, _name);
    }
}
