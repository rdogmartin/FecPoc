using FecPoc.UnitTests.Builders;
using Xunit;

namespace FecPoc.UnitTests.Core.Aggregates;

public class PartnerTests
{
    [Fact]
    public void NewPartnerHasNonNullProperties()
    {
        var p = MockPartnerBuilder.Get().ToPartner();

        Assert.NotNull(p.Name);
        Assert.NotNull(p.Name.First);
        Assert.NotNull(p.Name.Last);
    }
}
